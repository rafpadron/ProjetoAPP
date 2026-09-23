namespace ProjetoAPP;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Periodos_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PeriodosPage));
    }

    private async void Cursos_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CursosPage));
    }

    private async void Disciplinas_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DisciplinasPage));
    }
}