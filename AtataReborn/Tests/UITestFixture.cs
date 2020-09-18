using Atata;
using NUnit.Framework;
using NUnit.Framework.Internal;



namespace AtataReborn.Tests
{
    [TestFixture]
    
    public class UITestFixture 
    {

        public AtataConfig Config
        {
            get { return AtataConfig.Current; }
        }

        [SetUp] 
        public void SetUp()
        {
            AtataContext.Configure().ApplyJsonConfig<AtataConfig>().Build();
        }


        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
