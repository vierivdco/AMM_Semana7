using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace QR_Code
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnScannerQR_Clicked(object sender, EventArgs e) {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Hola mi nombre es Vieri Cervantes \nEsto es un lector QR";
                scanner.BottomText = "Laboratorio 08";
                var result = await scanner.Scan();
                if (result != null) {
                    txtResultado.Text = result.Text;
                }
            }
            catch (Exception ex) {

                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}
