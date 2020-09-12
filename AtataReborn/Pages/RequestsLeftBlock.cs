using Atata;

namespace AtataReborn.Pages
{
    using _ = RequestsLeftBlock;

    [WaitForElement(WaitBy.Class, "common-requests-registry-list__inner", Until.Visible, TriggerEvents.Init)]
    public class RequestsLeftBlock : Page<_>
    {
        [FindByXPath("//div[@class='menu menu_vertical']")]
        public Control<_> MenuButton { get; private set; }

        [FindByXPath("//div[@data-at='unified_survey-7']")]
        public Text<_> UnifiedSurvey { get; private set; }

        [FindByXPath("//div[@data-at='maintenance-1']")]
        public Text<_> Maintenance { get; private set; }

        [FindByXPath("//div[@data-at='document_sign-4']")]
        public Text<_> DocumentSign { get; private set; }

        [FindByXPath("//div[@data-at='business_trip-5']")]
        public Text<_> BusinessTrip { get; private set; }

        [FindByXPath("//div[@data-at='multipurpose-6']")]
        public Text<_> Multipurpose { get; private set; }

        [FindByXPath("//div[@data-at='holidays_control-8']")]
        public Text<_> HolidaysControl { get; private set; }

    }
}
