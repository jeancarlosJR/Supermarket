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
    public partial class ProviderView : Form,IProviderView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;
        public ProviderView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPageProviderDetail);

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

                tabControl1.TabPages.Remove(tabPageProviderList);
                tabControl1.TabPages.Add(tabPageProviderDetail);
                tabPageProviderDetail.Text = "Add New Product";

            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProviderList);
                tabControl1.TabPages.Add(tabPageProviderDetail);
                tabPageProviderDetail.Text = "Edit Product";
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPageProviderDetail);
                    tabControl1.TabPages.Add(tabPageProviderList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProviderDetail);
                tabControl1.TabPages.Add(tabPageProviderList);
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

        public string ProviderId
        {
            get { return TxtProviderId.Text; }
            set { TxtProviderId.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProviderName.Text; }
            set { TxtProviderName.Text = value; }
        }
        public string ProviderObservation
        {
            get { return TxtProviderObservation.Text; }
            set { TxtProviderObservation.Text = value; }
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

        public void SetProviderListBildingSource(BindingSource providerList)
        {
            DgProvider.DataSource = providerList;
        }

        private static ProviderView instance;

        public static ProviderView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProviderView();
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























































        private void DgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
