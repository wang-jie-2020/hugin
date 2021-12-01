using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.Localization;
using Volo.Abp.AspNetCore.Mvc.DataAnnotations;

namespace Hugin.Mvc.DataAnnotations
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
