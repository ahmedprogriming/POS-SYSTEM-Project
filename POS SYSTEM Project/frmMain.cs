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
    public partial class frmMain : Form
    {
        private clsUsers _User = new clsUsers();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDashMenu_Click(object sender, EventArgs e)
        {
            panSaidMenu.Visible=!panSaidMenu.Visible;   
        }


        private void frmMain_Activated(object sender, EventArgs e)
        {
            string RoleUser = "";
            _User = clsGlobal.Currentuser;

            switch (_User.RoleID)
            {
                case 1:
                    _User.NuRole = clsUsers.enRole.Admin;
                    break;
                case 2:
                    _User.NuRole = clsUsers.enRole.Manager;
                    break;
                case 3:
                    _User.NuRole = clsUsers.enRole.Cashier;
                    break;
                default:
                    lblNamerole.Text = "Unknown";
                    break;
            }

            RoleUser = _User.NameRole;

            lblNamerole.Text = RoleUser;

            btnUsers.Enabled = (lblNamerole.Text == "Admin");
            btnCategories.Enabled = (lblNamerole.Text == "Admin" || lblNamerole.Text == "Manager");
            btnProducts.Enabled = (lblNamerole.Text == "Admin" || lblNamerole.Text == "Manager");
            btnSuppliers.Enabled = (lblNamerole.Text == "Admin" || lblNamerole.Text == "Manager");
            btnReport.Enabled = (lblNamerole.Text == "Admin" || lblNamerole.Text == "Manager");
            btnInventory.Enabled = (lblNamerole.Text == "Admin" || lblNamerole.Text == "Manager");

            lblNameuser.Text = clsGlobal.Currentuser.FullName;
            lblNameWelcome.Text = clsGlobal.Currentuser.FullName;
            ibiRoleName2.Text= RoleUser;

        }

        private void TimerDateToDay_Tick(object sender, EventArgs e)
        {
            lblDateToday.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            lblTopTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TimerDateToDay.Start();
        }

        private void OpenFormInPanal(Form frm)
        {
            PanMain.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            PanMain.Controls.Add(frm);
            frm.Show();
        }

        private void brnSales_Click(object sender, EventArgs e)
        {
            OpenFormInPanal(new frmPOSSales());
        }
    }
}
