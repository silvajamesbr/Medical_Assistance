using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Views;
using Medical_Assistance;
using Medical_Assistance.Classes;
using Medical_Assistance.Services;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;

namespace Medical_Assistance;


public partial class Cadastro : ContentPage
{
    public ObservableCollection<Paciente> Pacientes { get; set; } = new ObservableCollection<Paciente>();

    private readonly DatabaseHelper _db;
    public Cadastro(DatabaseHelper db)
    {
        InitializeComponent();
        _db = db;

        BindingContext = this; // Define o binding da p�gina

        LoadPacientes();
    }

    private async void LoadPacientes() { 
    if (pickercadastro.SelectedItem?.ToString() == "Paciente")
    {
        var lista = await _db.GetPacientesAsync();
    Pacientes.Clear();
        foreach (var p in lista)
            Pacientes.Add(p);
    }
    }

    private async void novoCadastro_Clicked(object sender, EventArgs e)
    {
        if (pickercadastro.SelectedItem == null)
        {
            await DisplayAlert("Aten��o!", "Selecione um agente no canto superior esquerdo.", "OK");
            return;
        }

        string selectedValue = pickercadastro.SelectedItem.ToString();

        switch (selectedValue)
        {
            case "Estagi�rio":
                var popupEstagiario = new popupCadastroEstagiario();
                var resultEstagiario = await this.ShowPopupAsync(popupEstagiario);
                if (popupEstagiario.Resultado)
                {
                    await DisplayAlert("Sucesso", "Estagi�rio cadastrado!", "OK");
                }
                break;

            case "Profissional de Sa�de":
                var popupProfissional = new popupCadastroProfissional();
                var resultProfissional = await this.ShowPopupAsync(popupProfissional);
                if (popupProfissional.Resultado)
                {
                    await DisplayAlert("Sucesso", "Profissional cadastrado!", "OK");
                }
                break;

            case "Paciente":
                var popupPaciente = new popupCadastro(_db);
                var resultPaciente = await this.ShowPopupAsync(popupPaciente);
                if (popupPaciente.Resultado)
                {
                    await DisplayAlert("Sucesso", "Paciente Cadastrado!", "OK");
                    LoadPacientes();
                }
                break;

            case "Servi�o":
                var popupServico = new popupCadastroServico();
                var resultServico = await this.ShowPopupAsync(popupServico);
                if (popupServico.Resultado)
                {
                    await DisplayAlert("Sucesso", "Servi�o cadastrado!", "OK");
                }
                break;

            case "Sala":
                var popupSala = new popupCadastroSala();
                var resultSala = await this.ShowPopupAsync(popupSala);
                if (popupSala.Resultado)
                {
                    await DisplayAlert("Sucesso", "Sala cadastrada!", "OK");
                }
                break;

            default:
                await DisplayAlert("Aten��o!", "Op��o selecionada n�o � v�lida.", "OK");
                break;
        }
    }

    private void pickercadastro_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = pickercadastro.SelectedItem.ToString();

        switch (selectedValue)
        {
            case "Estagi�rio":

                break;

            case "Profissional de Sa�de":

                break;

            case "Paciente":
                LoadPacientes();
                break;

            case "Servi�o":

                break;

            case "Sala":

                break;

            default:
                
                break;
        }
    }
}
