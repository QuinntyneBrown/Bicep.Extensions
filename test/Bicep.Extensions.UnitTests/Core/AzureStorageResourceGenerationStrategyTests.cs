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
            var model = new AzureResourceFactory().CreateStorageAccount("Test");

            var expected = new List<string>()
            {
                "resource storageAccount 'Microsoft.Storage/storageAccounts@2021-08-01' = {",
                "  name: Test${uniqueString(resourceGroup().id)}",
                $"  location: resourceGroup().location",
                $"  kind: '{model.Kind}'",
                "  sku: {",
                $"    name: '{model.Sku.Name}'",
                "  }",
                "}"
            }.ToArray();

            var sut = new AzureStorageResourceGenerationStrategy(new AzureStorageSkuGenerationStrategy(), new AzureResourceSignatureGenerationStrategy());

            var actual = sut.Create(model);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldCreateResourceGroup()
        {
            var model = new AzureResourceFactory().CreateResourceGroup("'Test'","eastus");

            var expected = new List<string>()
            {
                "resource resourceGroup 'Microsoft.Resources/resourceGroups@2021-04-01' = {",
                "  name: 'Test'",
                $"  location: eastus",
                "}"
            }.ToArray();

            var sut = new AzureResourceGroupResourceGenerationStrategy(new AzureResourceSignatureGenerationStrategy());

            var actual = sut.Create(model);

            Assert.Equal(expected, actual);
        }
    }
}
