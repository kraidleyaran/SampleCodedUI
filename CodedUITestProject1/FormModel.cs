using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe;
using CUITe.Controls.WinControls;
using CUITe.SearchConfigurations;

namespace CodedUITestProject1
{
    public class FormModel
    {
        public WinWindow MainWindow;
        public WinText lbl_ChangingText;
        public WinButton btn_ChangeTxt;
        public WinEdit txtBox_ChangingBox;

        public FormModel()
        {
            MainWindow = new WinWindow(By.Name("Form1"));
            lbl_ChangingText = MainWindow.Find<WinText>(By.Name("lbl_ChangingText"));
            btn_ChangeTxt = MainWindow.Find<WinButton>(By.Name("btn_ChangingText"));
            txtBox_ChangingBox = MainWindow.Find<WinEdit>(By.Name("txtBox_ChangingText"));
        }
        public FormModel StartApplication() //You could use the file location as a parameter for this method
        {
            ApplicationUnderTest.Launch(@"C:\SampleApp\NewSampleApp.exe");
            return this;
        }

        public FormModel EnterTextIntoBox(string text)
        {
            txtBox_ChangingBox.Text = text;
            return this;
        }

        public FormModel PushButton()
        {
            btn_ChangeTxt.Click();
            return this;
        }

        public string GetTextFromLabel()
        {
            return lbl_ChangingText.DisplayText;
        }
    }
}