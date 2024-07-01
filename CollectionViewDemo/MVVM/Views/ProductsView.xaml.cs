using CollectionViewDemo.MVVM.ViewModels;

namespace CollectionViewDemo.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}

   

    private void CollectionView_Scrolled_1(object sender, ItemsViewScrolledEventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as ProductsViewModel;

        vm.Products.Add(new Models.ProductsGroup("New Group", new List<Models.Product>
        {
            new Models.Product
            {
                Id = 100,
                Name = "Bitcoin",
                Price = 999999
            }
        }));

        var product = vm.Products
            .SelectMany(p => p).FirstOrDefault(x => x.Id == 10);

        //collectionView.ScrollTo(product, position : ScrollToPosition.Center);
    }
}