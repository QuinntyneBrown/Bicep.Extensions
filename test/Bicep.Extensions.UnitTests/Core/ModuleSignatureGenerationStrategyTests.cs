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
            var expected = "module";

            var sut = new ModuleSignatureGenerationStrategy();

            var model = new ModuleFactory().Create("Foo");

            var actual = sut.Create(model);
            
            Assert.Equal(expected, actual); 
        }
    }
}
