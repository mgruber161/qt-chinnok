﻿using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using QTChinnok.MvvMApp.ViewModels;
using QTChinnok.MvvMApp.Views;

namespace QTChinnok.MvvMApp
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var viewModel = new MainViewModel();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = viewModel,
                };
                viewModel.Window = desktop.MainWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
