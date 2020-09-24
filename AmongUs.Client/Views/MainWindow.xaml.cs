using AmongUs.Client.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AmongUs.Client.Views {
	public class MainWindow: Window {
		public MainWindow() {
			InitializeComponent();

			Opened += (sender, args) => {
				GetHeader().Classes = Classes.Parse(GetViewModel().HeaderClasses);
			};
		}
		
		private TextBlock GetHeader() {
			return this.FindControl<TextBlock>("Header");
		}

		private MainWindowViewModel GetViewModel() {
			return DataContext as MainWindowViewModel;
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}
