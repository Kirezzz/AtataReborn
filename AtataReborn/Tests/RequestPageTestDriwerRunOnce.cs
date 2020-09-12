using Atata;
using NUnit.Framework;
using AtataReborn.Pages;


namespace AtataReborn.Tests
{
    public class RequestPageTestDriverRunOnce : UITestFixture
    {

        [Test]
        [Category("Smoke Tests")]
        public void CommonLeftBlockShouldContainDifferentRequestTypes()
        {

            Go.To<RequestsLeftBlock>().

                UnifiedSurvey.Should.Contain("Опросы").
                Maintenance.Should.Contain("МТО").
                DocumentSign.Should.Contain("Ознакомление с РД").
                BusinessTrip.Should.Contain("Командировки").
                Multipurpose.Should.Contain("Прочие заявки").
                HolidaysControl.Should.Contain("Постконтроль по выходным дням");
        }

        [Test]
        [Category("Smoke Tests")]
        public void CommonFilterBlockShouldContainCommonFilters()
        {
            //Шаги
            Go.To<RequestsFilterBlock>().
            OpenFilters.Click().

            //Проверки видимости
                RequestNumber.Should.BeVisible().
                RequestAutor.Should.BeVisible().
                DateFrom.Should.BeVisible().
                DateTo.Should.BeVisible().
                SubmitButton.Should.BeVisible().
                ClearButton.Should.BeVisible().

            //Проверки контента
                RequestNumber.Attributes.Placeholder.Should.Contain("№ заявки").
                RequestAutor.Attributes.Placeholder.Should.Contain("Автор заявки").
                DateFrom.Attributes.Placeholder.Should.Contain("ДД.ММ.ГГГГ").
                DateTo.Attributes.Placeholder.Should.Contain("ДД.ММ.ГГГГ").
                SubmitButton.Content.Should.Contain("ПРИМЕНИТЬ").
                ClearButton.Content.Should.Contain("ОЧИСТИТЬ").

                CloseFilters.Click();

        }

        [Test]
        [Category("Smoke Tests")]
        public void CommonRegistryShouldContainRequestPlates()
        {

            Go.To<RequestRegistryBlock>().
                Requests.Count.Should.Equal(5);
        }


        [Test]
        [Category("Regression Tests")]
        public void CheckMaintenancePlate()
        {
            Go.To<RequestsFilterBlock>().
            OpenFilters.Click().
            RequestNumber.Set("П-2103/20").
            SubmitButton.Click();

            Go.To<RequestRegistryBlock>().
            Requests[0].Info.Should.StartWith("Заявка на получение оборудования П-2103/20");

            Go.To<RequestsFilterBlock>().
                ClearButton.Click().
                CloseFilters.Click();
        }

        [Test]
        [Category("Regression Tests")]
        public void CheckDocumentSignPlate()
        {
            Go.To<RequestsFilterBlock>().
            OpenFilters.Click().
            RequestNumber.Set("Подп-122/20").
            SubmitButton.Click();

            Go.To<RequestRegistryBlock>().
            Requests[0].Info.Should.StartWith("№ Подп-122/20");

            Go.To<RequestsFilterBlock>().
                ClearButton.Click().
                CloseFilters.Click();
        }

        [Test]
        [Category("Regression Tests")]
        public void CheckBusinessTripPlate()
        {
            Go.To<RequestsFilterBlock>().
            OpenFilters.Click().
            RequestNumber.Set("249-КМ").
            SubmitButton.Click();

            Go.To<RequestRegistryBlock>().
            Requests[0].Info.Should.StartWith("249-КМ");

            Go.To<RequestsFilterBlock>().
                ClearButton.Click().
                CloseFilters.Click();
        }

        [Test]
        [Category("Regression Tests")]
        public void CheckMultipurposePlate()
        {
            Go.To<RequestsFilterBlock>().
            OpenFilters.Click().
            RequestNumber.Set("ПзНДФЛ-287/20").
            SubmitButton.Click();

            Go.To<RequestRegistryBlock>().
            Requests[0].Info.Should.StartWith("ПзНДФЛ-287/20");

            Go.To<RequestsFilterBlock>().
                ClearButton.Click().
                CloseFilters.Click();
        }

        [Test, Order(1)]
        [Category("Warm Up Tests")]
        public void WarmUpTest()
        {

            Go.To<RequestRegistryBlock>();
        }

    }
}