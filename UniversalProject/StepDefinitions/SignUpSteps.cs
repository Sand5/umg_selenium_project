using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using UniversalProject.ObjectRepositories;


namespace UniversalProject.StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            ObjectRepository.LandingPage.NavigateToSite();
        }
        
        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            ObjectRepository.SignUpPage = ObjectRepository.LandingPage.NavigateToSignUpForm();
            ObjectRepository.SignUpPage.EnterUserName()
                                        .EnterEmail()
                                        .EnterPassword();
            ObjectRepository.UserHomePage = ObjectRepository.SignUpPage.SignUp();
                                        
        }

      

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            Assert.IsTrue(ObjectRepository.UserHomePage.YourFeedLinkDisplayed());
        }
        
        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            Assert.IsTrue(ObjectRepository.UserHomePage.LoggedInUsNerNameDisplayed());
        }
    }
}
