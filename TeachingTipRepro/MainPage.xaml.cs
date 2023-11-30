namespace TeachingTipRepro;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void CopyButton_Clicked(object sender, RoutedEventArgs e)
    {
        ContentCopiedTip.IsOpen = true;
    }
}
