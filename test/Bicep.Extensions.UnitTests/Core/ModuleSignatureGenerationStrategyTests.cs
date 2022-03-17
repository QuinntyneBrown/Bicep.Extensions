using Bicep.Extensions.Core;
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

            var model = new ModuleFactory().Create("foo","foo.bicep");

            var actual = sut.Create(model);
            
            Assert.Equal(expected, actual); 
        }
    }
}
