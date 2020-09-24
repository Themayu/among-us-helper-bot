using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace AmongUs.Client.Theme {
	public class AppTheme : Styles {
		public AppTheme() {
			AvaloniaXamlLoader.Load(this);
		}
	}
}
