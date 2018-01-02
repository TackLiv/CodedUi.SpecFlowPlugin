namespace SpecFlow.CodedUI.MsTest.Examples.Models
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    using TackLiv.CodedUi.Fluent.Extensions;
    using TackLiv.CodedUi.Fluent.Helpers;

    public class PopupMessageModel : ModelBase
    {
        public PopupMessageModel()
        {
            this.Window = SelectHelper.SearchWindowByTitle("Notepad", "#32770");
        }

        public void ClickButton(string name)
        {
            this.Window.Select<WinButton>(name).Click();
        }
    }
}