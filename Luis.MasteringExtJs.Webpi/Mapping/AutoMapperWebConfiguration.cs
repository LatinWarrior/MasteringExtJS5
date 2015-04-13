namespace Luis.MasteringExtJs.WebApi.Mapping
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            PermissionMappingExtensions.Configure();
            MenuFlatMappingExtensions.Configure();            
            MenuTreeMappingExtensions.Configure();
            UserMappingExtensions.Configure();
        }
    }
}