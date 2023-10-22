namespace Supermarket.Views
{
    partial class CategorieView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieView));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgCategorie = new DataGridView();
            TxtSearch = new TextBox();
            label3 = new Label();
            tabPageCategorieDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategorieObservation = new TextBox();
            label6 = new Label();
            TxtCategorieName = new TextBox();
            label5 = new Label();
            TxtCategorieId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            tabPageCategorieDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 82);
            label1.TabIndex = 1;
            label1.Text = "PRODUCT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(24, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 22);
            label2.Name = "label2";
            label2.Size = new Size(201, 82);
            label2.TabIndex = 0;
            label2.Text = "CATEGORIE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Location = new Point(3, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 325);
            tabControl1.TabIndex = 4;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.BackgroundImageLayout = ImageLayout.Center;
            tabPageCategorieList.Controls.Add(BtnClose);
            tabPageCategorieList.Controls.Add(BtnDelete);
            tabPageCategorieList.Controls.Add(BtnEdit);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(DgCategorie);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label3);
            tabPageCategorieList.Location = new Point(4, 24);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(789, 297);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(551, 217);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(52, 41);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(551, 175);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(52, 36);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(551, 130);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(52, 39);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(551, 83);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(52, 41);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(551, 36);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(52, 41);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(15, 74);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowTemplate.Height = 25;
            DgCategorie.Size = new Size(490, 215);
            DgCategorie.TabIndex = 7;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(15, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(490, 23);
            TxtSearch.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 18);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Search Categorie";
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(BtnCancel);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(TxtCategorieObservation);
            tabPageCategorieDetail.Controls.Add(label6);
            tabPageCategorieDetail.Controls.Add(TxtCategorieName);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(TxtCategorieId);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Location = new Point(4, 24);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(789, 297);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(471, 96);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(52, 43);
            BtnCancel.TabIndex = 14;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(471, 47);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(52, 43);
            BtnSave.TabIndex = 13;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.Location = new Point(10, 191);
            TxtCategorieObservation.Multiline = true;
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.PlaceholderText = "Categorie Observation";
            TxtCategorieObservation.Size = new Size(341, 74);
            TxtCategorieObservation.TabIndex = 10;
            TxtCategorieObservation.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 162);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 9;
            label6.Text = "Categorie Observation";
            // 
            // TxtCategorieName
            // 
            TxtCategorieName.Location = new Point(10, 118);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.PlaceholderText = "Categorie Name";
            TxtCategorieName.Size = new Size(334, 23);
            TxtCategorieName.TabIndex = 8;
            TxtCategorieName.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 90);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 7;
            label5.Text = "Categorie Name";
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.Location = new Point(10, 47);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.ReadOnly = true;
            TxtCategorieId.Size = new Size(335, 23);
            TxtCategorieId.TabIndex = 6;
            TxtCategorieId.Text = "0";
            TxtCategorieId.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 19);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 5;
            label4.Text = "Categorie Id";
            // 
            // CategorieView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "CategorieView";
            Text = "CategorieView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private TextBox TxtSearch;
        private Label label3;
        private DataGridView DgCategorie;
        private Button BtnSearch;
        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Label label4;
        private TextBox TxtCategorieId;
        private Label label5;
        private TextBox TxtCategorieName;
        private Label label6;
        private TextBox TxtCategorieObservation;
        private Button BtnCancel;
        private Button BtnSave;
    }
}