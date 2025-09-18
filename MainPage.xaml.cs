using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Views;

namespace Medical_Assistance
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void botao_novoagendamento_Clicked(object sender, EventArgs e)
        {
            var popup = new PopupAgendamento();
            var result = await this.ShowPopupAsync(popup);

            if (popup.Resultado)
            {
                await DisplayAlert("Sucesso", "Agendamento confirmado!", "OK");
            }

        }
    }
}