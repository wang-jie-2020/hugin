using Magicodes.ExporterAndImporter.Excel;

namespace LG.NetCore.Infrastructure.Exporting
{
    [ExcelExporter(TableStyle = OfficeOpenXml.Table.TableStyles.Light10, AutoCenter = true, AutoFitAllColumn = true)]
    [ExcelImporter(IsLabelingError = true)]
    public abstract class DefaultExcelStyle
    {
    }
}
