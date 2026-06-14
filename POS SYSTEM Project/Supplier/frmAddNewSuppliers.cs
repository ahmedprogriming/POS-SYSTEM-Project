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
    public partial class frmAddNewSuppliers : Form
    {
        private clsSupplier _objSupplier;

        private int _SupplierID = -1;

        private enum _enMode { Addnew = 1, Update = 2 };

        _enMode Mode = _enMode.Addnew;
        public frmAddNewSuppliers()
        {
            InitializeComponent();
            Mode = _enMode.Addnew;
        }

        public frmAddNewSuppliers(int ID)
        {
            InitializeComponent();
            _SupplierID = ID;
            Mode = _enMode.Update;

        }

        private void _ReasultDefult()
        {

            if (Mode == _enMode.Addnew)
            {
                lblTitle.Text = "Add Product";
                _objSupplier = new clsSupplier();
            }

            else
            {
                lblTitle.Text = "Updte Product";

                lblSuppliersID.Text = _SupplierID.ToString();
            }

            lblSuppliersID.Text = "[????]";
            txtNameSuppliers.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        private void LoadData()
        {

            _objSupplier = clsSupplier.GetAllSupplierByID(_SupplierID);

            if (_objSupplier == null)
            {
                MessageBox.Show("Error", "This supplier is Null!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblSuppliersID.Text = _SupplierID.ToString();
            txtNameSuppliers.Text = _objSupplier.SupplierName;
            txtPhone.Text = _objSupplier.Phone;
            txtEmail.Text = _objSupplier.Email;
            txtAddress.Text = _objSupplier.Address;

        }

        private void frmAddNewSuppliers_Load(object sender, EventArgs e)
        {
            _ReasultDefult();

            if (Mode == _enMode.Update)
            {
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of save this supplier?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid, put the mouse over the red icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _objSupplier.SupplierID = _SupplierID;
                _objSupplier.SupplierName = txtNameSuppliers.Text;
                _objSupplier.Email = txtEmail.Text;
                _objSupplier.Phone = txtPhone.Text;
                _objSupplier.Address = txtAddress.Text;



                if (!_objSupplier.Save())
                {
                    MessageBox.Show("Not Saved..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Supplier save successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblSuppliersID.Text = _objSupplier.SupplierID.ToString();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorSupplier.SetError(txtEmail, "This filed is required!");
                return;
            }
            else
            {
                errorSupplier.SetError(txtEmail, null);
            }
        }

        private void txtNameSuppliers_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameSuppliers.Text))
            {
                e.Cancel = true;
                errorSupplier.SetError(txtNameSuppliers, "This filed is required!");
                return;
            }
            else
            {
                errorSupplier.SetError(txtNameSuppliers, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorSupplier.SetError(txtPhone, "This filed is required!");
                return;
            }
            else
            {
                errorSupplier.SetError(txtPhone, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                errorSupplier.SetError(txtAddress, "This filed is required!");
                return;
            }
            else
            {
                errorSupplier.SetError(txtAddress, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
