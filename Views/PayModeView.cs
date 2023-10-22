using MongoDB.Driver.Core.Operations;
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
    public partial class PayModeView : Form, IPayModeView
    {
        private string message;
        private bool isEdit;
        private bool isSuccessfull;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
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
        public bool IsSuccessfull
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public PayModeView()
        {
            InitializeComponent();
            AssociiateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociiateAndRaiseViewEvents()
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


                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = " Add New Pay Mode";
            };


            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = " Edit New Pay Mode";




            };




            BtnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }


            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessfull)
                {
                    tabControl1.TabPages.Remove(tabPagePayModeList);
                    tabControl1.TabPages.Add(tabPagePayModeDetail);
                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate
            {

                CancelEvent?.Invoke(this, EventArgs.Empty);


                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);



            };
        }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        private static PayModeView instance;

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
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
    }
}










