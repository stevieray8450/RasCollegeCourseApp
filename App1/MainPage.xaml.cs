using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ProcessCalc();
        }

        private void ProcessCalc()
        {
            Int32 Var1 = Convert.ToInt32(txtBoxInput1.Text) + Convert.ToInt32(txtBoxInput2.Text);
            txtBoxDisplay.Text = Convert.ToString(Var1);
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            ProcessSubtract();
        }

        private void ProcessSubtract()
        {
            int var1Verify;
            int var2Verify;
            int result;

            if (Int32.TryParse(txtBoxInput1.Text, out var1Verify) && (Int32.TryParse(txtBoxInput2.Text, out var2Verify)))
            {
                result = var1Verify - var2Verify;
                txtBoxDisplay.Text = Convert.ToString(result);
            }
            else
            {
                txtBoxDisplay.Text = "Invalid integer used. Please use numerals 0-9 only";
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            int var1Verify;
            int var2Verify;
            int result;

            if (Int32.TryParse(txtBoxInput1.Text, out var1Verify) && (Int32.TryParse(txtBoxInput2.Text, out var2Verify)))
            {
                result = var1Verify * var2Verify;
                txtBoxDisplay.Text = Convert.ToString(result);
            }
            else
            {
                txtBoxDisplay.Text = "Invalid integer used. Please use numerals 0-9 only";
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            double var1Verify;
            double var2Verify;
            double result;

            if (Double.TryParse(txtBoxInput1.Text, out var1Verify) && (Double.TryParse(txtBoxInput2.Text, out var2Verify)))
            {
                result = var1Verify / var2Verify;
                txtBoxDisplay.Text = Convert.ToString(result);
            }
            else
            {
                txtBoxDisplay.Text = "Invalid integer used. Please use numerals 0-9 only";
            }
        }

        async private void btnCourse1_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course1();
            txtBoxCourse.Text = BL_PageContent.VarOutput + "\n" + BL_PageContent.CreditsPrereq;
        }

        async private void btnCourse2_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course2();
            txtBoxCourse.Text = BL_PageContent.VarOutput + "\n" + BL_PageContent.CreditsPrereq;
        }

        async void btnCourse3_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course3();
            txtBoxCourse.Text = BL_PageContent.VarOutput + "\n" + BL_PageContent.CreditsPrereq;
        }

        public void hypLinkPage2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Faculty));
        }
    }
}
