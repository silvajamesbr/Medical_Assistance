namespace Medical_Assistance;
using CommunityToolkit.Maui.Views;

public partial class popupCadastroEstagiario : Popup
{
    public bool Resultado { get; private set; }
    public popupCadastroEstagiario()
	{
		InitializeComponent();
	}
    private void ConfirmarCadastro_Clicked(object sender, EventArgs e)
    {
        Resultado = true;
        CloseAsync();
    }

    private void CancelarCadastro_Clicked(object sender, EventArgs e)
    {
        Resultado = false;
        CloseAsync();
    }
}