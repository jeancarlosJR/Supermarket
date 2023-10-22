namespace Supermarket.Views
{
    partial class ProviderView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgProvider = new DataGridView();
            tabPageProviderDetail = new TabPage();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtProviderObservation = new TextBox();
            label5 = new Label();
            TxtProviderName = new TextBox();
            label4 = new Label();
            TxtProviderId = new TextBox();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabPageProviderDetail.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
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
            label1.Text = "PROVIDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 117);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 333);
            tabControl1.TabIndex = 6;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(792, 305);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(490, 23);
            TxtSearch.TabIndex = 7;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 13);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "Search Provider";
            label2.Click += label2_Click;
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(8, 79);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(490, 218);
            DgProvider.TabIndex = 0;
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderObservation);
            tabPageProviderDetail.Controls.Add(label5);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(792, 305);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(533, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(52, 39);
            BtnEdit.TabIndex = 14;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(533, 171);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(52, 36);
            BtnDelete.TabIndex = 13;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(533, 213);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(52, 41);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(533, 79);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(52, 41);
            BtnNew.TabIndex = 11;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small1;
            BtnSearch.Location = new Point(533, 31);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(52, 41);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(26, 190);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Provider Observation";
            TxtProviderObservation.Size = new Size(341, 74);
            TxtProviderObservation.TabIndex = 15;
            TxtProviderObservation.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 161);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 14;
            label5.Text = " Provider Observation";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(26, 116);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider Name";
            TxtProviderName.Size = new Size(334, 23);
            TxtProviderName.TabIndex = 13;
            TxtProviderName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 87);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 12;
            label4.Text = " Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(25, 41);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(335, 23);
            TxtProviderId.TabIndex = 11;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 18);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = " Provider Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(489, 108);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(52, 43);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(489, 59);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(52, 43);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "ProviderView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private DataGridView DgProvider;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtProviderObservation;
        private Label label5;
        private TextBox TxtProviderName;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}