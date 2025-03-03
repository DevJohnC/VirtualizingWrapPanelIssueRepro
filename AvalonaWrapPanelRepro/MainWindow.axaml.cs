using System.Reactive.Disposables;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Avalonia.Threading;
using ReactiveUI;

namespace AvalonaWrapPanelRepro;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    private const int BaseWidth = 100;
    private const int BaseHeight = 100;
    
    public MainWindow()
    {
        InitializeComponent();
        //this.WhenActivated(ConfigureBindings);
    }

    private void ConfigureBindings(CompositeDisposable d)
    {
        this.WhenAnyValue(v => v.PreviewTextScaleSlider.Value)
            .Subscribe(scale =>
            {
                Dispatcher.UIThread.Post(() =>
                {
                    Border1.Width = BaseWidth * scale;
                    Border1.Height = BaseHeight * scale;
                    
                    Border2.Width = BaseWidth * scale;
                    Border2.Height = BaseHeight * scale;
                    
                    Border3.Width = BaseWidth * scale;
                    Border3.Height = BaseHeight * scale;
                    
                    Border4.Width = BaseWidth * scale;
                    Border4.Height = BaseHeight * scale;
                });
            });
    }
}