using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AmongUs.Server.ViewModels;
using AmongUs.Server.Views;

namespace AmongUs.Server {
	public class App: Application {
		public override void Initialize() {
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted() {
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				desktop.MainWindow = new MainWindow {
					DataContext = new MainWindowViewModel(),
				};
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}
