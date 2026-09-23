namespace ProjetoAPP;

public partial class DisciplinasPage : ContentPage
{
    public DisciplinasPage()
    {
        InitializeComponent();
    }

    private async void Inserir_Clicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Inserir",
            "A função de inserir será implementada no futuro.",
            "OK");
    }

    private async void Alterar_Clicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Alterar",
            "A função de alterar será implementada no futuro.",
            "OK");
    }

    private async void Excluir_Clicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Excluir",
            "A função de excluir será implementada no futuro.",
            "OK");
    }
}