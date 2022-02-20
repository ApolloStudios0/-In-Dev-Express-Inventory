namespace Express_Inventory;

public partial class Welcome : Window
{
    // Load Indicator
    public bool LoggedInState { get; set; } = false;

    #region [Management Functions]

    public async void LoopManageText()
    {
        while (!LoggedInState)
        {
            FadeManager("Easily Manage Your Business Inventory");
            await Task.Delay(5000);
            FadeManager("Easily Manage Your Business Orders");
            await Task.Delay(5000);
            FadeManager("Easily Manage Your Business Replenishment");
            await Task.Delay(5000);
            FadeManager("Easily Manage Your Business E-Commerce Links");
        }
    }

    public async void FadeManager(string TextToChangeTo)
    {
        ManageText.Opacity = 0.9;
        await Task.Delay(50);
        ManageText.Opacity = 0.8;
        await Task.Delay(50);
        ManageText.Opacity = 0.7;
        await Task.Delay(50);
        ManageText.Opacity = 0.6;
        await Task.Delay(50);
        ManageText.Opacity = 0.5;
        await Task.Delay(50);
        ManageText.Opacity = 0.4;
        await Task.Delay(50);
        ManageText.Opacity = 0.3;
        await Task.Delay(50);
        ManageText.Opacity = 0.2;
        await Task.Delay(50);
        ManageText.Opacity = 0.1;
        await Task.Delay(50);
        ManageText.Content = TextToChangeTo;
        ManageText.Opacity = 0;
        await Task.Delay(50);
        ManageText.Opacity = 0.1;
        await Task.Delay(50);
        ManageText.Opacity = 0.2;
        await Task.Delay(50);
        ManageText.Opacity = 0.3;
        await Task.Delay(50);
        ManageText.Opacity = 0.4;
        await Task.Delay(50);
        ManageText.Opacity = 0.5;
        await Task.Delay(50);
        ManageText.Opacity = 0.6;
        await Task.Delay(50);
        ManageText.Opacity = 0.7;
        await Task.Delay(50);
        ManageText.Opacity = 0.8;
        await Task.Delay(50);
        ManageText.Opacity = 0.9;
        await Task.Delay(50);
        ManageText.Opacity = 1;
    }

    private void MoveTheForm(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        if (e.ButtonState == MouseButtonState.Pressed) { DragMove(); }
    }

    private void CloseTheForm(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void LoginButtonPressed(object sender, MouseButtonEventArgs e)
    {
        Authentication.LoginAuth.CheckAccessToken();
    }

    #endregion
    public Welcome()
    {
        // Load
        InitializeComponent();

        // Loop Manage Text
        LoopManageText();
    }

    #region [Sign In Fades] [ToDo: Fix This Shit]
    private async void SignUpNowClicked(object sender, MouseButtonEventArgs e)
    {
        SignInScreen.Opacity = 0.9;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.8;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.7;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.6;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.5;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.4;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.3;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.2;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.1;
        await Task.Delay(40);
        SignInScreen.Visibility = Visibility.Collapsed;
        SignUpScreen.Visibility = Visibility.Visible;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.1;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.2;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.3;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.4;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.5;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.6;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.7;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.8;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.9;
        await Task.Delay(40);
        SignUpScreen.Opacity = 1;
    }
    private async void SignInClicked(object sender, MouseButtonEventArgs e)
    {
        SignUpScreen.Opacity = 0.9;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.8;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.7;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.6;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.5;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.4;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.3;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.2;
        await Task.Delay(40);
        SignUpScreen.Opacity = 0.1;
        SignUpScreen.Visibility = Visibility.Collapsed;
        SignInScreen.Visibility = Visibility.Visible;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.1;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.2;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.3;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.4;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.5;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.6;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.7;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.8;
        await Task.Delay(40);
        SignInScreen.Opacity = 0.9;
        await Task.Delay(40);
        SignInScreen.Opacity = 1;
    }
    #endregion

}
