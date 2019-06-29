using ClassProjectBlueSkyCitadel1.PageObjects;
using ClassProjectBlueSkyCitadel1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ClassProjectBlueSkyCitadel1.StepDefinations
{
    [Binding]
    public class RegistrationSteps

    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }


        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }

        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }


        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastname()
        {
            registration.Enterlastname("Babatunde");     
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string p0)
        {
            registration.EnterEmailAddress("email");
        }

        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNo("07473373304");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword("master2000");
        }
        
        [When(@"I enter confirm password")]
        public void WhenIEnterConfirmPassword()
        {
            registration.EnterConfirmPassword("master2000");
        }
        
        [When(@"I click on Signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            registration.SuccessMessageIsDispalyed();
        }
    }
}
