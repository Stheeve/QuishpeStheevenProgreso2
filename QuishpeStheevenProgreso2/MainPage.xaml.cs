namespace QuishpeStheevenProgreso2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Chistes_Clicked(object sender, EventArgs e)
        {

        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grid());

        }
    }

}
