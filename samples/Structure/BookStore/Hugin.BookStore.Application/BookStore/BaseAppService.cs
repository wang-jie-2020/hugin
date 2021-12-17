﻿using Hugin.Application.Services;
using Hugin.BookStore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Hugin.BookStore
{
    [ApiExplorerSettings(GroupName = ApiGroups.Sample)]
    public abstract class BaseAppService : HuginApplicationService
    {
        protected BaseAppService()
        {
            LocalizationResource = typeof(BookStoreResource);
            ObjectMapperContext = typeof(BookStoreApplicationModule);
        }
    }
}
