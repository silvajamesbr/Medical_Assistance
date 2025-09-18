namespace Medical_Assistance;
using CommunityToolkit.Maui.Views;
using Services;
using Classes;

public partial class popupCadastro : Popup
{
    private readonly DatabaseHelper _db;
    public bool Resultado { get; private set; }
    public popupCadastro(DatabaseHelper db)
    {
        InitializeComponent();
        _db = db;

    }

    private async void ConfirmarCadastro_Clicked(object sender, EventArgs e)
    {
        try
        {
            // 1. Criar objeto Paciente com os dados do formulário
            var paciente = new Paciente
            {
                NomeCompleto = NomeEntry.Text,
                CPF = CpfEntry.Text,
                DataNascimento = DataNascimentoPicker.Date,
                Sexo = SexoPicker.SelectedItem?.ToString() ?? "",
                Telefone = TelefoneEntry.Text,
                Email = EmailEntry.Text,
                CEP = CepEntry.Text,
                Rua = RuaEntry.Text,
                Numero = NumeroEntry.Text,
                Cidade = CidadeEntry.Text,
                Estado = EstadoPicker.SelectedItem?.ToString() ?? "",
                Complemento = ComplementoEntry.Text
            };


            // 2. Salvar no banco
            await _db.AddPacienteAsync(paciente);

            Resultado = true;

            CloseAsync(); // fecha o popup
        }
        catch (Exception ex)
        {
            Resultado = false;
        }
    }


    private void CancelarCadastro_Clicked(object sender, EventArgs e)
    {
        Resultado = false;
        CloseAsync();
    }
}