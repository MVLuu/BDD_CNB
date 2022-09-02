using BDD_CNB.Drivers;
using BDD_CNB.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;


namespace BDD_CNB.StepDefinitions
{
    [Binding]
    public sealed class MainCNB
    {

        private readonly MainPageObject _mainCNBPageObject;

        private Preferred _preferredPageObject;

        public MainCNB(BrowserDriver browserDriver)
        {
            _mainCNBPageObject = new MainPageObject(browserDriver.Current);
        }

        [Given("a customer loads the main CNB page")]
        public void GivenMainCNBPageLoads()
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            
            
        }


        [When("the customer clicks the Preferred button")]
        public void WhenThePreferredButtonIsClicked()
        {
            _preferredPageObject = _mainCNBPageObject.ClickPreferredButton();
        }

        [Then("the Preferred page loads with title '(.*)'")]
        public void ThenThePreferredPageLoadsWithTitle(String expectedTitle)
        {
            var listTitles = TransformToListOfString(expectedTitle);
            _preferredPageObject.GetPageName().Should().ContainAny(listTitles);
        }

        [StepArgumentTransformation]
        public List<String> TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(",").ToList();
        }
    }
}