namespace CSharp101.ETradeWinForm;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbxProducts = new ListBox();
        lblProducts = new Label();
        lbxCart = new ListBox();
        btnAddToCart = new Button();
        btnRemoveFromCart = new Button();
        lblCart = new Label();
        SuspendLayout();
        // 
        // lbxProducts
        // 
        lbxProducts.FormattingEnabled = true;
        lbxProducts.Location = new Point(15, 38);
        lbxProducts.Margin = new Padding(4);
        lbxProducts.Name = "lbxProducts";
        lbxProducts.Size = new Size(207, 382);
        lbxProducts.TabIndex = 0;
        // 
        // lblProducts
        // 
        lblProducts.AutoSize = true;
        lblProducts.Location = new Point(15, 13);
        lblProducts.Margin = new Padding(4, 0, 4, 0);
        lblProducts.Name = "lblProducts";
        lblProducts.Size = new Size(63, 21);
        lblProducts.TabIndex = 1;
        lblProducts.Text = "Ürünler";
        // 
        // lbxCart
        // 
        lbxCart.FormattingEnabled = true;
        lbxCart.Location = new Point(483, 38);
        lbxCart.Name = "lbxCart";
        lbxCart.Size = new Size(207, 382);
        lbxCart.TabIndex = 2;
        // 
        // btnAddToCart
        // 
        btnAddToCart.Location = new Point(259, 38);
        btnAddToCart.Name = "btnAddToCart";
        btnAddToCart.Size = new Size(166, 57);
        btnAddToCart.TabIndex = 3;
        btnAddToCart.UseVisualStyleBackColor = true;
        btnAddToCart.Click += btnAddToCart_Click;
        // 
        // btnRemoveFromCart
        // 
        btnRemoveFromCart.Location = new Point(259, 101);
        btnRemoveFromCart.Name = "btnRemoveFromCart";
        btnRemoveFromCart.Size = new Size(166, 57);
        btnRemoveFromCart.TabIndex = 4;
        btnRemoveFromCart.UseVisualStyleBackColor = true;
        btnRemoveFromCart.Click += btnRemoveFromCart_Click;
        // 
        // lblCart
        // 
        lblCart.AutoSize = true;
        lblCart.Location = new Point(483, 13);
        lblCart.Margin = new Padding(4, 0, 4, 0);
        lblCart.Name = "lblCart";
        lblCart.Size = new Size(0, 21);
        lblCart.TabIndex = 5;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(702, 438);
        Controls.Add(lblCart);
        Controls.Add(btnRemoveFromCart);
        Controls.Add(btnAddToCart);
        Controls.Add(lbxCart);
        Controls.Add(lblProducts);
        Controls.Add(lbxProducts);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FormMain";
        Text = "E-Ticaret Ana Form";
        Load += FormMain_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox lbxProducts;
    private Label lblProducts;
    private ListBox lbxCart;
    private Button btnAddToCart;
    private Button btnRemoveFromCart;
    private Label lblCart;
}
