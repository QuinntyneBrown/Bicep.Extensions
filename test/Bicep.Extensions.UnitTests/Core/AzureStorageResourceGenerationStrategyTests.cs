using Bicep.Extensions.Core.Factories;
using Bicep.Extensions.Core.Strategies;
using System.Collections.Generic;
using Xunit;

namespace Bicep.Extensions.UnitTests.Core
{
    public class AzureStorageResourceGenerationStrategyTests
    {
        [Fact]
        public void ShouldCreate()
        {
            var model = new AzureResourceFactory().CreateStorageAccount();

            var expected = new List<string>()
            {
                "resource storageAccount 'Microsoft.Storage/storageAccounts@2021-08-01' = {",
                $"  name: {model.InstanceUniqueName}",
                $"  location: resourceGroup().location",
                $"  kind: '{model.Kind}'",
                "  sku: {",
                $"    name: '{model.Sku.Name}'",
                "  }",
                "}"
            }.ToArray();

            var sut = new AzureStorageResourceGenerationStrategy(new AzureStorageSkuGenerationStrategy(), new AzureResourceSignatureGenerationStrategy());

            var actual = sut.Create(model);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }

            Assert.Equal(expected, actual);
        }
    }
}
