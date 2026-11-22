# Sistema Acadêmico — .NET MAUI

Protótipo de app multiplataforma em **.NET MAUI (.NET 10)** para gestão acadêmica de **períodos, cursos e disciplinas**, desenvolvido em aula na faculdade de Análise e Desenvolvimento de Sistemas.

## Funcionalidades

- Menu principal com navegação para Períodos, Cursos e Disciplinas.
- Navegação lateral (Flyout) com `Shell`.
- Telas de cadastro com ações de **Inserir, Alterar e Excluir** (interface pronta; as ações exibem alertas de confirmação).
- Ícones com FontAwesome (`AathifMahir.Maui.MauiIcons.FontAwesome`).

## Tecnologias

C# · .NET 10 · .NET MAUI · XAML · Shell Navigation

## Plataformas

Android, iOS, Mac Catalyst e Windows (`net10.0-android`, `net10.0-ios`, `net10.0-maccatalyst`, `net10.0-windows10.0.19041.0`).

## Estrutura

| Arquivo | Descrição |
|---|---|
| `AppShell.xaml` | Navegação Flyout entre as telas |
| `MainPage.xaml` | Menu principal |
| `PeriodosPage.xaml` | Tela de períodos |
| `CursosPage.xaml` | Tela de cursos |
| `DisciplinasPage.xaml` | Tela de disciplinas |

## Como rodar

Pré-requisitos: .NET 10 SDK e o workload MAUI (`dotnet workload install maui`).

```bash
dotnet build ProjetoAPP/ProjetoAPP.csproj -t:Run -f net10.0-android
```

Ou abra `ProjetoAPP.slnx` no Visual Studio 2022+ e execute.

## Próximos passos

- Persistência com SQLite.
- Padrão MVVM com `CommunityToolkit.Mvvm`.
