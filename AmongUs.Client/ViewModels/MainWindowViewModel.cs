using ReactiveUI;

namespace AmongUs.Client.ViewModels {
	public class MainWindowViewModel: ViewModelBase {
		private bool isConnected;

		public bool IsConnected {
			get => isConnected;
			set => this.RaiseAndSetIfChanged(ref isConnected, value);
		}

		public string IsConnectedString => IsConnected ? "Connected" : "Disconnected";
		public string HeaderClasses => $"Header {IsConnectedString}";
	}
}
