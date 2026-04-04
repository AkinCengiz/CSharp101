using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrame;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Contexts;
using InterfaceAndGeneric.Business.Abstract;
using InterfaceAndGeneric.Business.Concrete;
using InterfaceExample.Entity.Concrete;

namespace WinFormUIApp;

public partial class Form1 : Form
{
    public Form1()
    {
        _categoryManager = new CategoryManager(new EfCategoryDal(new InterfaceAndGenericDbContext()));
        _productService = new ProductManager(new EfProductDal(new InterfaceAndGenericDbContext()));
        InitializeComponent();
    }

    private readonly ICategoryService _categoryManager;
    private readonly IProductService _productService;
    private void Form1_Load(object sender, EventArgs e)
    {
        
        
        //_categoryManager.Create(new Category(){ Name= "Bilgisayar"});
        //_categoryManager.Create(new Category(){Name = "Cep Telefonu"});
        //_productService.Create(new Product(){Name = "Samsung",CategoryId = 2,Price = 25000,Stock = 15});
        //_productService.Create(new Product() { Name = "Iphone", CategoryId = 2, Price = 35000, Stock = 13 });
        //_productService.Create(new Product() { Name = "Casper", CategoryId = 1, Price = 25000, Stock = 5 });

        dataGridView1.DataSource = _productService.GetAll();
    }
}
