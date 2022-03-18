using Bicep.Extensions.Core.Models;
using Bicep.Extensions.Core.Strategies;
using Xunit;

namespace Bicep.Extensions.UnitTests.Core
{
    public class ModuleSignatureGenerationStrategyTests
    {
        [Fact]
        public void ShouldCreate()
        {
            var expected = "module foo 'foo.bicep' = {";

            var sut = new ModuleSignatureGenerationStrategy();

            var model = new ModuleModel("foo","foo.bicep");

            var actual = sut.Create(model);
            
            Assert.Equal(expected, actual); 
        }
    }
}
