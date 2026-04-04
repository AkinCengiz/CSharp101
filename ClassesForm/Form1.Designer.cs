namespace ClassesForm;

partial class Form1
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
        lblSehir = new Label();
        txtSehir = new TextBox();
        lbxSehirler = new ListBox();
        lblSehirListesi = new Label();
        btnChange = new Button();
        gbxStudent = new GroupBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        txtNumber = new TextBox();
        lblNumber = new Label();
        txtLastName = new TextBox();
        lblLastName = new Label();
        btnSave = new Button();
        gbxStudent.SuspendLayout();
        SuspendLayout();
        // 
        // lblSehir
        // 
        lblSehir.AutoSize = true;
        lblSehir.Location = new Point(22, 19);
        lblSehir.Name = "lblSehir";
        lblSehir.Size = new Size(0, 15);
        lblSehir.TabIndex = 0;
        // 
        // txtSehir
        // 
        txtSehir.Location = new Point(100, 16);
        txtSehir.Name = "txtSehir";
        txtSehir.Size = new Size(100, 23);
        txtSehir.TabIndex = 1;
        // 
        // lbxSehirler
        // 
        lbxSehirler.FormattingEnabled = true;
        lbxSehirler.Location = new Point(22, 91);
        lbxSehirler.Name = "lbxSehirler";
        lbxSehirler.Size = new Size(178, 259);
        lbxSehirler.TabIndex = 2;
        // 
        // lblSehirListesi
        // 
        lblSehirListesi.AutoSize = true;
        lblSehirListesi.Location = new Point(22, 62);
        lblSehirListesi.Name = "lblSehirListesi";
        lblSehirListesi.Size = new Size(0, 15);
        lblSehirListesi.TabIndex = 3;
        // 
        // btnChange
        // 
        btnChange.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnChange.Location = new Point(288, 91);
        btnChange.Name = "btnChange";
        btnChange.Size = new Size(118, 68);
        btnChange.TabIndex = 4;
        btnChange.Text = "Değiştir";
        btnChange.UseVisualStyleBackColor = true;
        btnChange.Click += btnChange_Click;
        // 
        // gbxStudent
        // 
        gbxStudent.Controls.Add(btnSave);
        gbxStudent.Controls.Add(txtLastName);
        gbxStudent.Controls.Add(lblLastName);
        gbxStudent.Controls.Add(txtNumber);
        gbxStudent.Controls.Add(lblNumber);
        gbxStudent.Controls.Add(txtFirstName);
        gbxStudent.Controls.Add(lblFirstName);
        gbxStudent.Location = new Point(528, 16);
        gbxStudent.Name = "gbxStudent";
        gbxStudent.Size = new Size(294, 334);
        gbxStudent.TabIndex = 5;
        gbxStudent.TabStop = false;
        gbxStudent.Text = "Öğrenci Kayıt Formu";
        gbxStudent.Enter += gbxStudent_Enter;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Font = new Font("Segoe UI", 12F);
        lblFirstName.Location = new Point(15, 35);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(99, 21);
        lblFirstName.TabIndex = 0;
        lblFirstName.Text = "Öğrenci Adı :";
        // 
        // txtFirstName
        // 
        txtFirstName.Font = new Font("Segoe UI", 12F);
        txtFirstName.Location = new Point(161, 32);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(127, 29);
        txtFirstName.TabIndex = 1;
        // 
        // txtNumber
        // 
        txtNumber.Font = new Font("Segoe UI", 12F);
        txtNumber.Location = new Point(161, 107);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new Size(127, 29);
        txtNumber.TabIndex = 7;
        // 
        // lblNumber
        // 
        lblNumber.AutoSize = true;
        lblNumber.Font = new Font("Segoe UI", 12F);
        lblNumber.Location = new Point(15, 110);
        lblNumber.Name = "lblNumber";
        lblNumber.Size = new Size(144, 21);
        lblNumber.TabIndex = 6;
        lblNumber.Text = "Öğrenci Numarası :";
        // 
        // txtLastName
        // 
        txtLastName.Font = new Font("Segoe UI", 12F);
        txtLastName.Location = new Point(162, 72);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(127, 29);
        txtLastName.TabIndex = 9;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Font = new Font("Segoe UI", 12F);
        lblLastName.Location = new Point(15, 75);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(123, 21);
        lblLastName.TabIndex = 8;
        lblLastName.Text = "Öğrenci Soyadı :";
        // 
        // btnSave
        // 
        btnSave.Font = new Font("Segoe UI", 12F);
        btnSave.Location = new Point(161, 152);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(127, 34);
        btnSave.TabIndex = 10;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(834, 490);
        Controls.Add(gbxStudent);
        Controls.Add(btnChange);
        Controls.Add(lblSehirListesi);
        Controls.Add(lbxSehirler);
        Controls.Add(txtSehir);
        Controls.Add(lblSehir);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        gbxStudent.ResumeLayout(false);
        gbxStudent.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSehir;
    private TextBox txtSehir;
    private ListBox lbxSehirler;
    private Label lblSehirListesi;
    private Button btnChange;
    private GroupBox gbxStudent;
    private TextBox txtFirstName;
    private Label lblFirstName;
    private TextBox txtLastName;
    private Label lblLastName;
    private TextBox txtNumber;
    private Label lblNumber;
    private Button btnSave;
}
