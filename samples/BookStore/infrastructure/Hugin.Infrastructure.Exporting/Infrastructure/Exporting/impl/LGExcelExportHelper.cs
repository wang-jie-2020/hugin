using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Core.Extension;
using Magicodes.ExporterAndImporter.Excel.Utility;

namespace Hugin.Infrastructure.Exporting.impl
{
    public class LGExcelExportHelper<T> : ExportHelper<T> where T : class
    {
        protected override List<PropertyInfo> SortedProperties
        {
            get
            {
                var type = typeof(T);
                var objProperties = type.GetProperties()
                    .OrderBy(p => p.GetAttribute<ExporterHeaderAttribute>()?.ColumnIndex ?? 10000).ToList();

                //exclude complex type
                objProperties = objProperties
                    .Where(p => p.PropertyType.IsValueType || p.PropertyType == typeof(string))
                    .ToList();

                return objProperties;
            }
        }
    }
}
