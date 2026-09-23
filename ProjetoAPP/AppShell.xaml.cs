namespace ProjetoAPP;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(PeriodosPage), typeof(PeriodosPage));
        Routing.RegisterRoute(nameof(CursosPage), typeof(CursosPage));
        Routing.RegisterRoute(nameof(DisciplinasPage), typeof(DisciplinasPage));
    }
}