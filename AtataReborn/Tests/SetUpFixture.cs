using Atata;
using Atata.ExtentReports;
using AtataSamples.ExtentReports;
using NUnit.Framework;




namespace AtataReborn.Tests
{
    [SetUpFixture]
    public class SetUpFixture
    {


        [OneTimeSetUp]
        public void GlobalSetUp()
        {   

            AtataContext.
                GlobalConfiguration.               
            UseChrome().
            WithArguments("start-maximized").
            WithLocalDriverPath().
            //("disable-extensions", "start-maximized", "disable-infobars").
            UseNUnitTestName().
            AddNUnitTestContextLogging().
            //AddScreenshotFileSaving().
            //        WithFolderPath(() => $@"Logs\{AtataContext.BuildStart:yyyy-MM-dd HH_mm_ss}\{AtataContext.Current.TestName}").
            //        WithFileName(screenshotInfo => $"{screenshotInfo.Number:D2} - {screenshotInfo.PageObjectFullName}{screenshotInfo.Title?.Prepend(" - ")}").
            AddNLogLogging().
            //WithFolderPath(() => $@"Logs\{AtataContext.BuildStart:yyyy-MM-dd HH_mm_ss}").
            //WithFileName(screenshotInfo => $"{AtataContext.Current.TestName} - {screenshotInfo.PageObjectFullName}").
            LogNUnitError().
            TakeScreenshotOnNUnitError().
        // Extent Reports specific configuration:
            AddLogConsumer(new ExtentLogConsumer()).
            AddScreenshotConsumer(new ExtentScreenshotConsumer());
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            ExtentContext.Reports.Flush();
        }
    }
}
