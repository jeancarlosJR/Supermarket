namespace Supermarket.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgProduct = new DataGridView();
            tabPageProdutDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductObservation = new TextBox();
            label5 = new Label();
            TxtProductName = new TextBox();
            label4 = new Label();
            TxtProductId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProdutDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 22);
            label1.Name = "label1";
            label1.Size = new Size(201, 82);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProdutDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 117);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 333);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.BackgroundImageLayout = ImageLayout.Center;
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 305);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            tabPageProductList.Click += tabPageProductList_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(528, 117);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(52, 39);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(528, 162);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(52, 36);
            BtnDelete.TabIndex = 8;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(528, 204);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(52, 41);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(528, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(52, 41);
            BtnNew.TabIndex = 6;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click_1;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(528, 22);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(52, 41);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(18, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(490, 23);
            TxtSearch.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 14);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Search Product";
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(18, 70);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(490, 214);
            DgProduct.TabIndex = 0;
            // 
            // tabPageProdutDetail
            // 
            tabPageProdutDetail.Controls.Add(BtnCancel);
            tabPageProdutDetail.Controls.Add(BtnSave);
            tabPageProdutDetail.Controls.Add(TxtProductObservation);
            tabPageProdutDetail.Controls.Add(label5);
            tabPageProdutDetail.Controls.Add(TxtProductName);
            tabPageProdutDetail.Controls.Add(label4);
            tabPageProdutDetail.Controls.Add(TxtProductId);
            tabPageProdutDetail.Controls.Add(label3);
            tabPageProdutDetail.Location = new Point(4, 24);
            tabPageProdutDetail.Name = "tabPageProdutDetail";
            tabPageProdutDetail.Padding = new Padding(3);
            tabPageProdutDetail.Size = new Size(792, 305);
            tabPageProdutDetail.TabIndex = 1;
            tabPageProdutDetail.Text = "Product Detail";
            tabPageProdutDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(440, 93);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(52, 43);
            BtnCancel.TabIndex = 12;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(440, 44);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(52, 43);
            BtnSave.TabIndex = 11;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(26, 193);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.PlaceholderText = "Product Observation";
            TxtProductObservation.Size = new Size(341, 74);
            TxtProductObservation.TabIndex = 9;
            TxtProductObservation.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 164);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 8;
            label5.Text = " Product Observation";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(26, 119);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(334, 23);
            TxtProductName.TabIndex = 7;
            TxtProductName.TextAlign = HorizontalAlignment.Center;
            TxtProductName.TextChanged += TxtProductName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 90);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 6;
            label4.Text = " Product Name";
            label4.Click += label4_Click;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(25, 44);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(335, 23);
            TxtProductId.TabIndex = 5;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Center;
            TxtProductId.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 21);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = " Product Id";
            label3.Click += label3_Click;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProdutDetail.ResumeLayout(false);
            tabPageProdutDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProdutDetail;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProductId;
        private Label label3;
        private TextBox TxtProductObservation;
        private Label label5;
        private TextBox TxtProductName;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
    }
}