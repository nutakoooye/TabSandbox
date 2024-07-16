using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;

namespace TabSandbox.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Tab> Tabs { get; set; }
    public ReactiveCommand<Tab, Unit> CloseTabCommand { get; }

    public MainWindowViewModel()
    {
        Tabs = new()
        {
            new() { Title = "Tool 1",  Value = "Content1" },
            new() { Title = "Tool 2", Value = "Content2" },
            new() { Title = "Tool 3", Value = "Content3" },
            new() { Title = "Tool 4", Value = "Content4" },
            new() { Title = "Tool 5", Value = "Content5" },
            new() { Title = "Tool 6", Value = "Content6" },
            new() { Title = "Tool 7", Value = "Content7" },
            new() { Title = "Tool 8", Value = "Content8" },
            new() { Title = "Tool 9", Value = "Content9" },
            new() { Title = "Tool 10", Value = "Content10" },
            new() { Title = "Tool 11", Value = "Content11" },
        };

        CloseTabCommand = ReactiveCommand.Create<Tab>(item => Tabs.Remove(item));
    }
}