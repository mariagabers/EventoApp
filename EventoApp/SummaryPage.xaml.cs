namespace EventoApp;

public partial class SummaryPage : ContentPage
{
    public SummaryPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}
