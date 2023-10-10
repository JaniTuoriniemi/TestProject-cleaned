using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class FeaturnewtryStepDefinitions
    {
        public CalculatorPageObject _calculatorPageObject;

        public FeaturnewtryStepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        }
        //This is är test1.It tests the steps 1-4 in Test scenario 2.

        [Given(@"Webbläsaren är oinloggad på ta emot sidan:")]
        public void GivenWebblasarenArOinloggadPaTaEmotSidan()
        {
            _calculatorPageObject.GotoPage1();
           // _calculatorPageObject.ClickLoginButton();

        }

        [When(@"Ta emot är klickad:")]
        public void WhenTaEmotArKlickad()
        {
            _calculatorPageObject.ClickTa_emot();
        }

        [Then(@"webläsaren tas till login sidan:")]
        public void ThenWeblasarenTasTillLoginSidan()
        {
            string word = "Koopa11Kiipa";
            string number = "730622401";
            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);
            _calculatorPageObject.ClickLoginButton();
            if (_calculatorPageObject.CurrentURL() == "https://reink.se/book/leave-book?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27")
            {
                string desired_page = "https://reink.se/book/leave-book?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27";
                string actualResult = _calculatorPageObject.CurrentURL();
                actualResult.Should().Be(desired_page);
            }
            else
            { 
                _calculatorPageObject.ClickTa_emot();
                string desired_page2 = "https://reink.se/book/book-registered";
                string actualResult2 = _calculatorPageObject.CurrentURL();
                actualResult2.Should().Be(desired_page2);
            }
        }
        //This is är test2.It tests the steps 6-7b-9 in Test scenario 2.
        [Given(@"webläsaren är åter på ta emot sidan:")]
        public void GivenWeblasarenArAterPaTaEmotSidan()
        {//_calculatorPageObject.GotoPage1();
           // _calculatorPageObject.ClickLogOutButton();
           _calculatorPageObject.GotoPage2();
            _calculatorPageObject.ClickLämmnaPåAddressButton();
        }

        [When(@"ta emot"" klickas igen:")]
        public void WhenTaEmotKlickasIgen()
        {
            
            string word = "Koopa11Kiipa";
            string number = "730622401";
            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);
            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"det ska nu stå bok registrerad:")]
        public void ThenDetSkaNuStaBokRegistrerad()
        {
        
            string desired_page = "https://reink.se/book/leave-book-on-map?code=eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd";
            string actualResult = _calculatorPageObject.CurrentURL();
            actualResult.Should().Be(desired_page);
        }

        [Given(@"webbläsaren är utloggad:")]
        public void GivenWebblasarenArUtloggad()
        {
            throw new PendingStepException();


        }

        [When(@"QR koden skannas och webläsaren tas till https://reink\.se/book/register-qr\?QrCode=eebe(.*)(.*)ce(.*)-a(.*)(.*)f(.*)ef(.*)cd:")]
        public void WhenQRKodenSkannasOchWeblasarenTasTillHttpsReink_SeBookRegister_QrQrCodeEebece_Afefcd(Decimal p0, int p1, Decimal p2, Decimal p3, Decimal p4, int p5, Decimal p6)
        {

            throw new PendingStepException();
        }

        [Then(@"det ska stå ""([^""]*)"":")]
        public void ThenDetSkaSta(string p0)
        {
            throw new PendingStepException();

           
        }
        //This is är test4.It tests the steps 9-7b-10 in Test scenario 2.
        [Given(@"webläsaren står på ""([^""]*)"" sidan:")]
        public void GivenWeblasarenStarPaSidan(string p0)
        {
            _calculatorPageObject.GotoPage3();
            string word = "Koopa11Kiipa";
            string number = "730622401";
            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);
            _calculatorPageObject.ClickLoginButton();


        }

        [When(@"klicka på nästa och logga in:")]
        public void WhenKlickaPaNastaOchLoggaIn()
        {
            string phone = "+46730622401";
            string price = "1";
            // _calculatorPageObject.StatePrice(price);
            _calculatorPageObject.MoveSlider();
            _calculatorPageObject.StateSwishnumber(phone);
            _calculatorPageObject.ClickBetalaSwish();
        }

        [Then(@"jag är klar"" sidan ska visas:")]
        public void ThenJagArKlarSidanSkaVisas()
        {
            string desired_page = "https://reink.se/account/paymentswishapp";
            string actualResult = _calculatorPageObject.CurrentURL();
            actualResult.Should().Be(desired_page);
        }

        [When(@"Nästa klickas:")]
        public void WhenNastaKlickas()
        {

            throw new PendingStepException();
        }

        [Then(@"Betalasidan ska visas:")]
        public void ThenBetalasidanSkaVisas()
        {

            throw new PendingStepException();

        }
        //This is är test6.It tests the steps 6-10 in Test scenario 2.
        [Given(@"webläsaren är på ""([^""]*)"" sidan:")]
        public void GivenWeblasarenArPaSidan(string betala)
        {
            _calculatorPageObject.GotoPage2();
            _calculatorPageObject.ClickNästaButtonLämna();
            
        }

        [When(@"sätt prist till (.*) kr:")]
        public void WhenSattPristTillKr(int p0)
        {
            string word = "Koopa11Kiipa";
            string number = "730622401";
            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);
            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"Betalningen ska vara klar:")]
        public void ThenBetalningenSkaVaraKlar()
        {
            string desired_page = "https://reink.se/account/payment-swish?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27";
            string actualResult = _calculatorPageObject.CurrentURL();
            actualResult.Should().Contain(desired_page);
        }
    }
}
