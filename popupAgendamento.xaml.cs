using CommunityToolkit.Maui.Views;

namespace Medical_Assistance
{
    public partial class PopupAgendamento : Popup
    {
        public bool Resultado { get; private set; }

        public PopupAgendamento()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            Resultado = true;
            CloseAsync();
        }

        // Se quiser cancelar
        private void Cancelar_Clicked(object sender, EventArgs e)
        {
            Resultado = false;
            CloseAsync();
        }

        
    }
}