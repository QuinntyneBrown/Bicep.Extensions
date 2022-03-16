using Bicep.Extensions.Core.Factories;
using Bicep.Extensions.Core.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bicep.Extensions.UnitTests.Core
{
    public class AzureResourceSignatureGenerationStrategyTests
    {
        [Fact]
        public void ShouldCreate()
        {
            var expected = "resource storageAccount 'Microsoft.Storage/storageAccounts@2021-08-01' = {";

            var sut = new AzureResourceSignatureGenerationStrategy();

            var model = new AzureResourceFactory().CreateStorageAccount("Test");

            var actual = sut.Create(model);

            Assert.Equal(expected, actual);
        }
    }
}
