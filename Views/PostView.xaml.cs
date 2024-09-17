using AulaMVVMHTTPClient.ViewModels;

namespace AulaMVVMHTTPClient.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		BindingContext = new PostViewModel();
		InitializeComponent();
	}
}