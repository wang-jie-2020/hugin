﻿//using Microsoft.OpenApi.Any;
//using Microsoft.OpenApi.Models;
//using Swashbuckle.AspNetCore.SwaggerGen;

//namespace LG.NetCore.Platform.Swagger
//{
//    /// <summary>
//    /// OpenApi的规范Schema
//    /// </summary>
//    public class AutoRestSchemaFilter : ISchemaFilter
//    {
//        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
//        {
//            var type = context.Type;
//            if (type.IsEnum)
//            {
//                schema.Extensions.Add(
//                    "x-ms-enum",
//                    new OpenApiObject
//                    {
//                        ["name"] = new OpenApiString(type.Name),
//                        ["modelAsString"] = new OpenApiBoolean(false),
//                    }
//                );
//            };
//        }
//    }
//}
