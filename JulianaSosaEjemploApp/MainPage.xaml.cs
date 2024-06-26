﻿namespace JulianaSosaEjemploApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string translatedNumber;
        public MainPage()
        {
            InitializeComponent();//realiza la interpretacion a cs
        }

        

        //creacion del metodo ontraslate tras poner click derecho
        private void OnTranslate(object sender, EventArgs e)
        {
           
            string enteredNumber = PhoneNumberText.Text;
          translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }
        }

        //convertimos el metodo a asincronico
         async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
        "Dial a Number",
        "Would you like to call " + translatedNumber + "?",
        "Yes",
        "No"))
            {
                // TODO: dial the phone
            }
        }
    }

}
