using Busisns_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM_Project
{
    public partial class frmHistory : Form
    {
        private int _TransID = -1;
        public frmHistory(int id)
        {
            InitializeComponent();
            _TransID = id;
        }
        private void _LoadData()
        {
            clsInventoryTransaction transaction = clsInventoryTransaction.GetAllProccesTransactionByID(_TransID);

            if (transaction == null)
            {
                MessageBox.Show("there problem in load data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDate.Text = transaction.TransactionDate.ToString("dd/mm/yyyy");
            lblProduct.Text = transaction.ProductID.ToString();
            lblType.Text=clsCategory.GetAllCategoriesByID( transaction.objProduct.CategoryID).CategoryName;
            lblUser.Text=clsUsers.GetUserByID(transaction.CreatedByUserID).Username;
            txtNotes.Text = transaction.Notes;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}