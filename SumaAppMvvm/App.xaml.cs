using SumaAppMvvm.View;

namespace SumaAppMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraSuma();
        }
    }
}
