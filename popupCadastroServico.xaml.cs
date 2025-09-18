namespace Medical_Assistance;
using CommunityToolkit.Maui.Views;
public partial class popupCadastroServico : Popup
{
    public bool Resultado { get; private set; }
    public popupCadastroServico()
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