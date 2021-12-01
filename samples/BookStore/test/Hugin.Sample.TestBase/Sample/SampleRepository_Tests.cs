﻿using Volo.Abp.Modularity;

namespace LG.NetCore.Sample
{
    /* Write your custom repository tests like that, in this project, as abstract classes.
     * Then inherit these abstract classes from EF Core & MongoDB test projects.
     * In this way, both database providers are tests with the same set tests.
     */
    public abstract class SampleRepository_Tests<TStartupModule> : SampleTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        //private readonly ISampleRepository _sampleRepository;

        protected SampleRepository_Tests()
        {
            //_sampleRepository = GetRequiredService<ISampleRepository>();
        }
    }
}
