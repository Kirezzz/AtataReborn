using Atata;

namespace AtataReborn.Pages
{
    using _ = RequestsFilterBlock;

    [WaitForElement(WaitBy.Class, "common-requests-registry-list__inner", Until.Visible, TriggerEvents.Init)]
    public class RequestsFilterBlock : Page<_>
    {
        
        [FindByXPath("//div[@class='common-filter-tongue']")]
        public Control<_> OpenFilters { get; private set; }

        [FindByXPath("//div[@data-at='right-block-head']")]
        public Control<_> CloseFilters { get; private set; }

        [FindByPlaceholder("№ заявки")]
        public TextInput<_> RequestNumber { get; private set; }

        [FindByPlaceholder("Автор заявки")]
        public TextInput<_> RequestAutor { get; private set; }

        [FindByXPath("//div[@class='common-requests-registry-filter-group']/div[3]/div[1]/div[1]/label[1]/input[@placeholder='ДД.ММ.ГГГГ']")]
        public TextInput<_> DateFrom { get; private set; }

        [FindByXPath("//div[@class='common-requests-registry-filter-group']/div[4]/div[1]/div[1]/label[1]/input[@placeholder='ДД.ММ.ГГГГ']")]
        public TextInput<_> DateTo { get; private set; }

        [FindByXPath("//div[@class='common-requests-registry-filter-controls']/div[1]/div[contains(text(),'ПРИМЕНИТЬ')]")]
        public Control<_> SubmitButton { get; private set; }

        [FindByXPath("//div[@class='common-requests-registry-filter-controls']/div[2]/div[contains(text(),'ОЧИСТИТЬ')]")]
        //[WaitForElement(WaitBy.Class, "common-requests-registry-list__inner", Until.Visible, TriggerEvents.AfterClick)]
        public Control<_> ClearButton { get; private set; }
    }
}
