namespace Bicep.Extensions.Core
{
    public static class CoreConstants
    {
        public static class SymbolicNames
        {
            public static readonly string StorageAccount = "storageAccount";
            public static readonly string WebApp = "webApp";
            public static readonly string AppServicePlan = "appServicePlan";
            public static readonly string SqlDatabase = "sqlDatabase";
            public static readonly string ResourceGroup = "resourceGroup";
        }

        public static class AzureStorageAccountResource
        {
            public static class Kind
            {
                public static readonly string StorageV2 = nameof(StorageV2);
                public static readonly string Storage = nameof(Storage);
                public static readonly string BlogStorage = nameof(BlogStorage);
                public static readonly string BlockBlobStorage = nameof(BlockBlobStorage);
                public static readonly string FileStorage = nameof(FileStorage);
            }
            public static class Skus
            {
                public static readonly string Standard = "Standard_LRS";
            }

            public static class SkuNames
            {
                public static readonly string Standard = "Stanard_LRS";
            }
        }

        public static class AzureSqlDatabaseResource
        {
            public static class Kind
            {
            }

            public static class Skus
            {
            }

            public static class SkuNames
            {
            }
        }
    }
}
