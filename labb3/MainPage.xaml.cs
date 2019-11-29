using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labb3
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            eightButton.Clicked += (s, e) => CalculateVat(8);
            twelveButton.Clicked += (s, e) => CalculateVat(12);
            twentyFiveButton.Clicked += (s, e) => CalculateVat(25);
        }

        private void CalculateVat(double vat)
        {
            if (Double.TryParse(amountInput.Text, out double amount) && amount > 0)
            {
                double calculatedAmount = amount / (1 + (vat / 100));
                double calculatedVat = amount - calculatedAmount;

                calculatedAmountOutput.Text = calculatedAmount.ToString("0.00") + " SEK";
                calculatedVatOutput.Text = calculatedVat.ToString("0.00") + " SEK";

                enteredAmountOutput.Text = amount.ToString("0.00") + " SEK";
                vatRateOutput.Text = vat.ToString() + "%";
            }
        }
    }
}
