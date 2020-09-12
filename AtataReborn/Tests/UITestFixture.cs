using Atata;
using NUnit.Framework;
using AtataReborn.Properties;
using Atata.Configuration.Json;

namespace AtataReborn.Tests
{
    [TestFixture]
    
    public class UITestFixture
    {

        public AtataConfig Config
        {
            get { return AtataConfig.Current; }
        }

        [OneTimeSetUp]

        public void SetUp()
        {

            AtataContext.Configure().
                ApplyJsonConfig<AtataConfig>().
                UseChrome().WithArguments
                ("start-maximized").
                //("disable-extensions", "start-maximized", "disable-infobars").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                AddScreenshotFileSaving().
                        WithFolderPath(() => $@"Logs\{AtataContext.BuildStart:yyyy-MM-dd HH_mm_ss}\{AtataContext.Current.TestName}").
                        WithFileName(screenshotInfo => $"{screenshotInfo.Number:D2} - {screenshotInfo.PageObjectFullName}{screenshotInfo.Title?.Prepend(" - ")}").
                AddNLogLogging().
                //WithFolderPath(() => $@"Logs\{AtataContext.BuildStart:yyyy-MM-dd HH_mm_ss}").
                //WithFileName(screenshotInfo => $"{AtataContext.Current.TestName} - {screenshotInfo.PageObjectFullName}").
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
