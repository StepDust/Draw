public partial class App : Application
{
	public App()
	{
		this.InitializeComponent();
	}

	protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
	{
		m_window = new MainWindow();
		m_window.Activate();
	}

	// 修改前
	// private Window m_window;
	// 修改后
	public static Window m_window;
}
