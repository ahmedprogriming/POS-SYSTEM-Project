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
    public partial class AddEditCategory : Form
    {
        private clsCategory _Categoryobj;

        private int _Categoryid = -1;

        private enum _enMode { Addnew = 1, Update = 2 };

        _enMode Mode = _enMode.Addnew;
        public AddEditCategory()
        {
            InitializeComponent();

            Mode = _enMode.Addnew;
        }

        public AddEditCategory(int ID)
        {
            InitializeComponent();
            _Categoryid = ID;

            Mode = _enMode.Update;
        }

        private void _ReasultDefult()
        {

            if (Mode == _enMode.Addnew)
            {
                lblTitle.Text = "Add Product";
                _Categoryobj = new clsCategory();
            }

            else
            {
                lblTitle.Text = "Updte Product";

                lblCategoryID.Text = _Categoryid.ToString();
            }

            lblCategoryID.Text = "[????]";
            txtBNameCategory.Text = "";
            txtDescription.Text = "";

        }

        private void LoadData()
        {

            _Categoryobj = clsCategory.GetAllCategoriesByID(_Categoryid);

            if (_Categoryobj == null)
            {
                MessageBox.Show("Error", "This product is Null!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCategoryID.Text = _Categoryid.ToString();
            txtBNameCategory.Text = _Categoryobj.CategoryName;
            txtDescription.Text = _Categoryobj.Description;


        }

        private void AddEditCategory_Load(object sender, EventArgs e)
        {
            _ReasultDefult();

            if (Mode == _enMode.Update)
            {
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of save this categorie?", "Confirm Opition", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!this.ValidateChildren())
                {
                    MessageBox.Show("Some fields are not valid, put the mouse over the red icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Categoryobj.CategoryID = _Categoryid;
                _Categoryobj.CategoryName = txtBNameCategory.Text;
                _Categoryobj.Description = txtDescription.Text;



                if (!_Categoryobj.Save())
                {
                    MessageBox.Show("Not Saved..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Categorie save successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCategoryID.Text = _Categoryobj.CategoryID.ToString();
            }
        }

        private void txtBNameCategory_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBNameCategory.Text))
            {
                e.Cancel = true;
                errorProviderCategory.SetError(txtBNameCategory, "This filed is required!");
                return;
            }
            else
            {
                errorProviderCategory.SetError(txtBNameCategory, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                e.Cancel = true;
                errorProviderCategory.SetError(txtDescription, "This filed is required!");
                return;
            }
            else
            {
                errorProviderCategory.SetError(txtDescription, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
