using SumaAppMvvm.ViewModel;

namespace SumaAppMvvm.View;

public partial class CalculadoraSuma : ContentPage
{

	private CalculadoraSumaViewModel viewModel; 
	public CalculadoraSuma()
	{
		viewModel = new CalculadoraSumaViewModel();
		this.BindingContext = viewModel; 
	}
}