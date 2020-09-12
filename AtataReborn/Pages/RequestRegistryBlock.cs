using Atata;

namespace AtataReborn.Pages
{
    using _ = RequestRegistryBlock;

    [WaitForElement(WaitBy.Class, "common-requests-registry-list__inner", Until.Visible, TriggerEvents.Init, PresenceTimeout = 10)]
    public class RequestRegistryBlock : Page<_>
        {

        public ControlList<RequestsItem, _> Requests { get; private set; }

        [ControlDefinition("div", ContainingClass = "uavp-registry-plate ")]
        public class RequestsItem : Control<_>
        {
            //[FindByClass("uavp-header-plate__title")]
            [FindByClass(Constants.Info)]
            public Text<_> Info { get; private set; }

            //[FindByXPath("//div[@class='uavp-header-plate__status']/div[1]")]
            [FindByXPath(Constants.Status)]
            public Text<_> Status { get; private set; }

            //[FindByXPath("//div[@class='uavp-body-plate__value']/span[1]")]
            [FindByXPath(Constants.Consumer)]
            public Text<_> Consumer { get; private set; }
        }
    }
    
}
