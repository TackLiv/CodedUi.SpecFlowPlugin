namespace SpecFlow.CodedUI.MsTest.Examples.Steps
{
    using Microsoft.VisualStudio.TestTools.UITesting;

    using Shouldly;

    using SpecFlow.CodedUI.MsTest.Examples.Models;

    using TackLiv.CodedUi.Fluent.Extensions;

    using TechTalk.SpecFlow;

    [Binding]
    public class NotepadEditingSteps
    {
        private ApplicationUnderTest app;

        private NotepadMainModel main;

        private PopupMessageModel popup;

        [Given(@"I launched notepad application")]
        public void GivenILaunchedNotepadApplication()
        {
            this.app = ApplicationUnderTest.Launch(@"c:\Windows\notepad.exe");
            this.app.CloseOnPlaybackCleanup = true;
        }

        [Then(@"I click close button")]
        public void ThenIClickCloseButton()
        {
           this.main.Close();
        }

        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string p0)
        {
            this.popup.ClickButton(p0);
        }

        [Then(@"Verify the notepad application close")]
        public void ThenTheNotepadApplicationClose()
        {
            this.main.Window.ValidateExistsOrNot(false);
        }

        [When(@"I enter ""(.*)""")]
        public void WhenIEntere(string p0)
        {
            this.main = new NotepadMainModel();
            this.main.TextAreaEdit.Text = p0;
        }

        [Then(@"Verify that '(.*)' displayed")]
        public void ThenVerifyThatDisplayed(string p0)
        {
            this.main.TextAreaEdit.Text.ShouldBe(p0);
        }

        [Then(@"Verify the PopupWindow should show on the screen")]
        public void ThenVerifyThePopupWindowShouldShowOnTheScreen()
        {
            this.popup = new PopupMessageModel();
            this.popup.Window.ValidateExistsOrNot(true);
        }

        [Then(@"Verify that PopupWindow should disapeared")]
        public void ThenVerifyThatPopupWindowShouldDisapeared()
        {
            this.popup.Window.ValidateExistsOrNot(false);
        }


    }
}