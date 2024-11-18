namespace EventoApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nomeEntry.Text) ||
            dataInicioPicker.Date == null ||
            dataTerminoPicker.Date == null ||
            string.IsNullOrWhiteSpace(participantesEntry.Text) ||
            string.IsNullOrWhiteSpace(localEntry.Text) ||
            string.IsNullOrWhiteSpace(custoEntry.Text))
        {
            await DisplayAlert("Erro", "Preencha todos os campos obrigatórios.", "OK");
            return;
        }

        // Crie o evento com os dados do formulário
        var evento = new Evento
        {
            Nome = nomeEntry.Text,
            DataInicio = dataInicioPicker.Date,
            DataTermino = dataTerminoPicker.Date,
            NumeroParticipantes = int.Parse(participantesEntry.Text),
            Local = localEntry.Text,
            CustoPorParticipante = double.Parse(custoEntry.Text)
        };

        // Navegue para a página de resumo
        await Navigation.PushAsync(new SummaryPage(evento));
    }
}
