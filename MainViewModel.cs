using UraniumUI;
using UraniumUI.Dialogs;

namespace Medical_Assistance
{
    public class MainViewModel : UraniumBindableObject
    {
        private readonly IDialogService _dialogService;

        public MainViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            NovoAgendamentoCommand = new Command(async () => await ExecuteNovoAgendamento());
        }

        public Command NovoAgendamentoCommand { get; }

        private async Task ExecuteNovoAgendamento()
        {
            bool result = await _dialogService.ConfirmAsync(
                "Novo Agendamento",
                "Deseja criar um novo agendamento?",
                "Sim", "Não");

            if (result)
            {
                // Lógica para novo agendamento
            }
        }
    }
}