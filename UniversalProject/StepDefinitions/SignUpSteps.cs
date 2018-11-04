using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using UniversalProject.ObjectRepositories;
using UniversalProject.Pages;

namespace UniversalProject.StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            //Create an instance of the LandingPage object
            ObjectRepository.LandingPage = new LandingPage(ObjectRepository.Driver);
            
            //We navigate to the application site
            ObjectRepository.LandingPage.NavigateToSite();
        }

        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            //We then click on the on the signup page button
            ObjectRepository.SignUpPage = ObjectRepository.LandingPage.NavigateToSignUpForm();


            /*We enter some random dummy form data in the signup form page thiss makes running 
             * the feature reusable since we using randam data in all of the form fields.
             */
            ObjectRepository.SignUpPage.EnterUserName()
                                        .EnterEmail()
                                        .EnterPassword();

            //We then sign up based on the data we have entered
            ObjectRepository.UserHomePage = ObjectRepository.SignUpPage.SignUp();

        }


        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            /*We then assert true if the your feed link is displayed as this is  
             * only displayed once the user has logged in successfully
             */
            Assert.IsTrue(ObjectRepository.UserHomePage.YourFeedLinkDisplayed());
        }

        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            //We then assert true if the user name is also displayed on the user homepage 
            Assert.IsTrue(ObjectRepository.UserHomePage.LoggedInUsNerNameDisplayed());
        }
    }
}
