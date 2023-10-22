using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.Views
{
    public partial class CategorieView : Form, ICategorieView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;

        public CategorieView()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tabPageCategorieDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Add New Product";

            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Edit Product";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPageCategorieDetail);
                    tabControl1.TabPages.Add(tabPageCategorieList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieDetail);
                tabControl1.TabPages.Add(tabPageCategorieList);
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Product",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string CategorieId
        {
            get { return TxtCategorieId.Text; }
            set { TxtCategorieId.Text = value; }
        }
        public string CategorieName
        {
            get { return TxtCategorieName.Text; }
            set { TxtCategorieName.Text = value; }
        }
        public string CategorieObservation
        {
            get { return TxtCategorieObservation.Text; }
            set { TxtCategorieObservation.Text = value; }
        }


        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEevent;
        public event EventHandler CancelEvent;
        public event EventHandler SaveEvent;


        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategorie.DataSource = categorieList;
        }

        private static CategorieView instance;

        public static CategorieView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategorieView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        

















        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPageProductList_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click_1(object sender, EventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
        }

        
    }
}
