using Busisns_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace POS_SYSTEM_Project
{
    public partial class frmReports : Form
    {
        
        DataTable Reportsdt;

        DateTime FromDate= DateTime.MinValue;
        DateTime ToDate= DateTime.MinValue;
        private frmMain _frmMain;
        enum enReType { daily=1,Monthly=2,Yearly=3};

        enReType ReType;

        public frmReports(frmMain main)
        {
            InitializeComponent();
            _frmMain = main;
        }

        private void SpicReportType()
        {
            switch(cobReports.Text)
            {
                case "Daily Sales":
                    ReType= enReType.daily; break;
                case "Monthly Sales":
                    ReType= enReType.Monthly; break;
                case "Yearly Sales":
                    ReType = enReType.Yearly; break;
            }
        }

        private void GenrateReport(DataTable reportDt)
        {
            dgvReportList.DataSource = reportDt;

            if (dgvReportList.Rows.Count > 0)
            {
                dgvReportList.Columns[0].HeaderText = "InvoiceNumber";
                dgvReportList.Columns[0].Width = 150;

                dgvReportList.Columns[1].HeaderText = "SaleDate";
                dgvReportList.Columns[1].Width = 200;

                dgvReportList.Columns[2].HeaderText = "ProductName";
                dgvReportList.Columns[2].Width = 200;

                dgvReportList.Columns[3].HeaderText = "Total";
                dgvReportList.Columns[3].Width = 200;

                dgvReportList.Columns[4].HeaderText = "PaymentStatus";
                dgvReportList.Columns[4].Width = 200;



            }

            dgvReportList.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
            dgvReportList.EnableHeadersVisualStyles = false;

            dgvReportList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);

        }
        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private void cobReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpicReportType();

            dtFrom.Enabled = (ReType != enReType.daily);
            dtToDate.Enabled = (ReType != enReType.daily);

          
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if(ReType == enReType.daily)
            {
                Reportsdt = clsReports.GetDailySales();

                GenrateReport(Reportsdt);
            }else
            {
                FromDate=dtFrom.Value;
                ToDate=dtToDate.Value;

                Reportsdt = clsReports.GetMonthlyAndYearSales(FromDate, ToDate);

                GenrateReport(Reportsdt);
            }
        }

        private void ExportToExcel(DataTable dt)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "SalesReport.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(dt, "Report");

                    workbook.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Excel exported successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ExportToPDF(DataTable dt)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "PDF Files|*.pdf";
            sfd.FileName = "SalesReport.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document document =
                    new Document(PageSize.A4, 10f, 10f, 20f, 20f);

                PdfWriter.GetInstance(document,
                    new FileStream(sfd.FileName, FileMode.Create));

                document.Open();

                Paragraph title = new Paragraph(
                    "Sales Report",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));

                title.Alignment = Element.ALIGN_CENTER;

                document.Add(title);
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(
                    $"Generated Date: {DateTime.Now}"));

                document.Add(new Paragraph(" "));

                PdfPTable table =
                    new PdfPTable(dt.Columns.Count);

                table.WidthPercentage = 100;

                // Header
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell =
                        new PdfPCell(new Phrase(column.ColumnName));

                    cell.HorizontalAlignment =
                        Element.ALIGN_CENTER;

                    table.AddCell(cell);
                }

                // Data
                foreach (DataRow row in dt.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(value?.ToString() ?? "");
                    }
                }

                document.Add(table);

                document.Close();

                MessageBox.Show("PDF exported successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            _frmMain.DefultShaw();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            ExportToPDF(Reportsdt);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(Reportsdt);
        }
    }
}
