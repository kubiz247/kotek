using static System.Net.WebRequestMethods;

namespace kotek
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string link = "https://cataas.com/cat";
            Kotek.Source = link;
        }

        private void OnSliderValueChange(object sender, ValueChangedEventArgs args)
        {
            
            double value = args.NewValue;
            Kotek.HeightRequest = value;
        }
    }
}

