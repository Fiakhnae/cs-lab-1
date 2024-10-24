using CSLab1.ViewModels;

namespace CSLab1.Views;

public partial class TestPage : ContentPage
{
	public TestPage(TestViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}