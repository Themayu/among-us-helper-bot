using AmongUs.Client.Theme;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AmongUs.Client.ViewModels;
using AmongUs.Client.Views;

namespace AmongUs.Client {
	public class App: Application {
		public override void Initialize() {
			AvaloniaXamlLoader.Load(this);
			LoadTheme();
		}

		public override void OnFrameworkInitializationCompleted() {
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
				desktop.MainWindow = new MainWindow {
					DataContext = new MainWindowViewModel(),
				};
			}

			base.OnFrameworkInitializationCompleted();
		}

		private void LoadTheme() {
			Styles.Add(new AppTheme());
		}
	}
}
