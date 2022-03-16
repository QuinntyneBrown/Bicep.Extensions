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
    public class AzureResourceGenerationStrategyTests
    {
        [Fact]
        public void ShouldCreateAzureStorageResource()
        {
            var expected = new List<string>()
            {
                "resource storageAccount 'Microsoft.Storage/storageAccounts@2021-08-01' = {",
                "}"
            }.ToArray();

            var model = new AzureResourceFactory().CreateStorageAccount();

            var sut = new AzureResourceGenerationStrategy();

            var actual = sut.Create(model);

            Assert.Equal(expected, actual);
        }
    }
}
