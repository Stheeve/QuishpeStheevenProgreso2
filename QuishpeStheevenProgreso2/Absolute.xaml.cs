using System.Text.Json;

namespace QuishpeStheevenProgreso2;

public partial class Absolute : ContentPage
{
    public Absolute()
    {
        InitializeComponent();
        CargarChiste(); 
    }

    
    private async void OtroChiste_Clicked(object sender, EventArgs e)
    {
        await CargarChiste();
    }

    
    private async Task CargarChiste()
    {
        var httpClient = new HttpClient();
        var json = await httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
        var joke = JsonSerializer.Deserialize<Joke>(json);

      
       Chiste.Text = $"{joke.setup}\n\n{joke.punchline}";
    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
