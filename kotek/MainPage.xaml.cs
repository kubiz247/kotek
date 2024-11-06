namespace kotek
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Kotek.Source = "https://cataas.com/cat?";
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Kotek.Source = "https://cataas.com/cat/cute/says/" + Kotek2.Text;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            Kotek.Source = "https://cataas.com/cat/gif";
        }
        private void OnCounterClicked4(object sender, EventArgs e)
        {
            Kotek.Source = "https://cataas.com/cat/cute/says/" + Kotek3.Text;
        }
    }
}

