using ClassProjectBlueSkyCitadel1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectBlueSkyCitadel1.PageObjects
{
    class RegistrationPage
    {
        private string myEmail;

        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
            
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstname { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#last_name")]
        private IWebElement lastname { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.Name, Using = "mobile")]
        private IWebElement mobileNo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement SuccessMessage { get; set; }

        public bool SuccessMessageIsDispalyed()
        {
            return SuccessMessage.Displayed;
        }

        public void EnterMobileNo(string mobile)
        {
            mobileNo.SendKeys(mobile);
        }

        public void Enterlastname(string lastnameText)
        {
            lastname.SendKeys("lastnameText");
        }
        public void ClickSignUp()
        {
            signUp.Click();
        }
        public void EnterConfirmPassword(string confirmPasswordText)
        {
            confirmPassword.SendKeys(confirmPasswordText);
        }

        public void EnterPassword(string passwordText)
        {
            password.SendKeys(passwordText);
        }

        public void MobileNumber(string mobile)
        {
            mobileNumber.SendKeys(mobile);
        }

        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);
        }

        public void EnterFirstName()
        {
            firstname.SendKeys("Muyiwa");
        }


        public void ClickOnRegister()
    {
        register.Click();
    }
    }
}
