namespace Volo.Abp.MultiStadium.ConfigurationStore
{
    public class AbpDefaultStadiumStoreOptions
    {
        public StadiumConfiguration[] Stadiums { get; set; }

        public AbpDefaultStadiumStoreOptions()
        {
            Stadiums = new StadiumConfiguration[0];
        }
    }
}