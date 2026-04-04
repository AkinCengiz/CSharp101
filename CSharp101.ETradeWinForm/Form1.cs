namespace CSharp101.ETradeWinForm;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        lblProducts.Text = "Ürünler";
        btnAddToCart.Text = "Sepete Ekle >>";
        btnRemoveFromCart.Text = "<< Sepetten Çıkar";
        lblCart.Text = "Sepet";
        btnRemoveFromCart.Enabled = false;

        string[] products = new string[] { "Dizüstü Bilgisayar", "Masaüstü Bilgisayar", "Klavye" };
        //lbxProducts.Items.Add("Dizüstü Bilgisayar");
        //lbxProducts.Items.Add("Masaüstü Bilgisayar");
        //lbxProducts.Items.Add("Klavye");

        //for (int i = 0; i < products.Length; i++)
        //{
        //    lbxProducts.Items.Add(products[i]);
        //}

        foreach (var product in products)
        {
            lbxProducts.Items.Add(product);
        }
        //lbxProducts.DataSource = products;
    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        if (lbxProducts.SelectedItem != null)
        {
            lbxCart.Items.Add(lbxProducts.SelectedItem);
            btnRemoveFromCart.Enabled = true;
        }
        else
        {
            MessageBox.Show("Bir ürün seçmelisiniz...");
        }
    }

    private void btnRemoveFromCart_Click(object sender, EventArgs e)
    {
        if (lbxCart.SelectedItem != null)
        {
            lbxCart.Items.Remove(lbxCart.SelectedItem);
        }
        else
        {
            MessageBox.Show("Bir ürün seçmelisiniz...");
        }

        if (lbxCart.Items.Count == 0)
        {
            btnRemoveFromCart.Enabled = false;
        }
    }
}
