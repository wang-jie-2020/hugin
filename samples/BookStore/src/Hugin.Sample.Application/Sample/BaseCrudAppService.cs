using LG.NetCore.Infrastructure.Exporting;
using LG.NetCore.Sample.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using LG.NetCore.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace LG.NetCore.Sample
{
    public abstract class BaseCrudAppService<TEntity, TKey, TEntityDto, TGetListInput, TEntityEditDto, TGetEditOutputDto, TCreateOrUpdateInput>
           : BaseCrudAppService<TEntity, TKey, TEntityDto, TEntityDto, TGetListInput, TEntityEditDto, TGetEditOutputDto, TCreateOrUpdateInput, TCreateOrUpdateInput>
    where TKey : struct
    where TEntity : class, IEntity<TKey>
    where TEntityDto : class, new()
    where TEntityEditDto : new()
    where TGetEditOutputDto : new()
    {
        protected BaseCrudAppService(IRepository<TEntity, TKey> repository) : base(repository)
        {
        }
    }

    [ApiExplorerSettings(GroupName = ApiGroups.Sample)]
    public abstract class BaseCrudAppService<TEntity, TKey, TGetOutputDto, TGetListOutputDto, TGetListInput, TEntityEditDto, TGetEditOutputDto, TCreateInput, TUpdateInput>
        : LGCrudAppService<TEntity, TKey, TGetOutputDto, TGetListOutputDto, TGetListInput, TEntityEditDto, TGetEditOutputDto, TCreateInput, TUpdateInput>
    where TKey : struct
    where TEntity : class, IEntity<TKey>
    where TGetListOutputDto : class, new()
    where TEntityEditDto : new()
    where TGetEditOutputDto : new()
    {
        protected BaseCrudAppService(IRepository<TEntity, TKey> repository) : base(repository)
        {
            LocalizationResource = typeof(SampleResource);
            ObjectMapperContext = typeof(SampleApplicationModule);
        }

        private IExcelExporting _excelExport;
        protected IExcelExporting ExcelExport => this.LazyGetRequiredService<IExcelExporting>(ref this._excelExport);

        public virtual async Task<FileContentResult> GetExcel(TGetListInput input)
        {
            var output = await GetListAsync(input);
            var list = output.Items.ToList();
            var buffer = await ExcelExport.ExportAsync(list);

            return new FileContentResult(buffer, System.Net.Mime.MediaTypeNames.Application.Octet)
            {
                FileDownloadName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx"

            };
        }

        //public virtual async Task<FileContentResult> GetImportTemplate()
        //{
        //    /*
        //     * object 替换
        //     */
        //    var buffer = await ExcelExport.ExportTemplateAsync<object>();

        //    return new FileContentResult(buffer, System.Net.Mime.MediaTypeNames.Application.Octet)
        //    {
        //        FileDownloadName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx"
        //    };
        //}

        //public virtual async Task ImportExcel(IFormFile formFile)
        //{
        //    /*
        //     * object 替换
        //     */
        //    var items = await ExcelExport.ImportTemplateAsync<object>(formFile.OpenReadStream());
        //}
    }
}


