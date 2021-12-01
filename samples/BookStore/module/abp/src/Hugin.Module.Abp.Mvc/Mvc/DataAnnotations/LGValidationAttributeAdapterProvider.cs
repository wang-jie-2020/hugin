using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.DataAnnotations;

namespace LG.NetCore.Mvc.DataAnnotations
{
    public class LGValidationAttributeAdapterProvider : AbpValidationAttributeAdapterProvider
    {
        public LGValidationAttributeAdapterProvider(ValidationAttributeAdapterProvider defaultAdapter)
            : base(defaultAdapter)
        {
        }

        public override IAttributeAdapter GetAttributeAdapter(ValidationAttribute attribute, IStringLocalizer stringLocalizer)
        {
            return base.GetAttributeAdapter(attribute, stringLocalizer);
        }
    }
}
