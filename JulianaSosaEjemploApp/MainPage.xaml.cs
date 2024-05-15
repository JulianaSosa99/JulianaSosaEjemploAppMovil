namespace JulianaSosaEjemploApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();//realiza la interpretacion a cs
        }

        private void OnCounterClicked(object sender, EventArgs e) //de los conceptos mas importantes "EVENT HANDLER: le decimos a la app que quiere que haag cuando sucede un evento hola"
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
