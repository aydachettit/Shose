using Shoes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Azure;

namespace Shoes.GUI
{
    public partial class Form_ADD : Form
    {
        int index;
        string HDiDcheck;
        string supplieridcheck;
        string datetimecheck;
        public Form_ADD()
        {
            InitializeComponent();
        }
        public void loadform()
        {
            dgvHD.DataSource = addBLL.Instance.getaddlist();
            lblnumnote.Text = addBLL.Instance.getnumnote();
            lblnumsupplier.Text = addBLL.Instance.getnumsupplier();
        }
        public void loaddetailform()
        {
            dataGridView2.DataSource = adddetailBLL.Instance.getadddetaillist(tbHDid.Text);
            cbproductid.DataSource = shoesBLL.Instance.getShoesList();
            cbproductid.DisplayMember = "ProductID";
            cbproductid.ValueMember = "ProductID";
            lblproductnamevalue.Text = "Name";
            lblsoluong.Text = "0";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            lblnum.Text = dataGridView2.Rows.Count.ToString();
            lblnum0.Text = adddetailBLL.Instance.getproductidcount(tbHDid.Text).ToString();
            lbltotalmoney.Text = adddetailBLL.Instance.gettotalhd(tbHDid.Text).ToString() + " VND";
        }
        private void Form_ADD_Load(object sender, EventArgs e)
        {
            loadform();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addBLL.Instance.checkinsertadd(tbHDid.Text, tbSupplierID.Text, dateTimePicker1.Text);
            loadform();
        }

        private void btnEdit_Click(object sender, EventArgs e) 
        {

            if (HDiDcheck == tbHDid.Text)
            {
                addBLL.Instance.updateadd(tbHDid.Text, tbSupplierID.Text, dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Không được thay đổi Mã Đơn hàng");
            }
            loadform();
    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (HDiDcheck == tbHDid.Text)
            {
                addBLL.Instance.deleteadd(tbHDid.Text);
            }
            else
            {
                MessageBox.Show("Không được thay đổi Mã Đơn hàng");
            }
            loadform();
        }

        private void btnResetGridView_Click(object sender, EventArgs e)
        {
            tbHDid.Text = "";
            tbSupplierID.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            tbNhapId.Text = "";
            loadform();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvHD.DataSource = addBLL.Instance.search(tbNhapId.Text);
        }

        private void btnAdddetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                tbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                adddetailBLL.Instance.insertdetail(tbHDid.Text, cbproductid.Text, lblproductnamevalue.Text, Convert.ToInt32(lblsoluong.Text), float.Parse(tbPrice.Text), Convert.ToInt32(tbQuantity.Text));
                adddetailBLL.Instance.updatetoshoes(cbproductid.Text, float.Parse(tbPrice.Text));
            }
            loaddetailform();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                tbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                adddetailBLL.Instance.deletedetail(tbHDid.Text, cbproductid.Text);
            }
            loaddetailform();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                tbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                if (dataGridView2.Rows.Count > 0)

                {

                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "PHIEUNHAP_"+tbHDid.Text+".pdf";

                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)

                    {

                        if (File.Exists(save.FileName))

                        {

                            try

                            {

                                File.Delete(save.FileName);

                            }

                            catch (Exception ex)

                            {

                                ErrorMessage = true;

                                MessageBox.Show("Unable to wride data in disk" + ex.Message);

                            }

                        }

                        if (!ErrorMessage)

                        {

                            try

                            {

                                PdfPTable pTable = new PdfPTable(dataGridView2.Columns.Count);

                                pTable.DefaultCell.Padding = 2;

                                pTable.WidthPercentage = 100;

                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in dataGridView2.Columns)

                                {

                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                    pTable.AddCell(pCell);

                                }

                                foreach (DataGridViewRow viewRow in dataGridView2.Rows)

                                {

                                    foreach (DataGridViewCell dcell in viewRow.Cells)

                                    {

                                        pTable.AddCell(dcell.Value.ToString());

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

                                    document.Add(pTable);

                                    document.Close();

                                    fileStream.Close();

                                }

                                MessageBox.Show("Data Export Successfully", "info");

                            }

                            catch (Exception ex)

                            {

                                MessageBox.Show("Error while exporting Data" + ex.Message);

                            }

                        }

                    }

                }

                else

                {

                    MessageBox.Show("No Record Found", "Info");

                }

             }
            loaddetailform();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                tbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                dataGridView2.DataSource = "";
                DataTable dt = new DataTable();
                cbproductid.DataSource = dt;
                lblproductnamevalue.Text = "Name";
                tbPrice.Text = "";
                lblsoluong.Text = "0";
                tbQuantity.Text = "";
                lblnum.Text = "0";
                lblnum0.Text = "0";
                lbltotalmoney.Text = "0 VND";
            }
        }

        private void btnResetdetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                tbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                cbproductid.DataSource = shoesBLL.Instance.getShoesList();
                cbproductid.DisplayMember = "ProductID";
                cbproductid.ValueMember = "ProductID";
                lblproductnamevalue.Text = "Name";
                tbPrice.Text = "";
                lblsoluong.Text = "0";
                tbQuantity.Text = "";
            }
        }

        private void dgvHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHD.Rows.Count > 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = dgvHD.Rows[index];
                tbHDid.Text = row.Cells[0].Value.ToString();
                HDiDcheck = row.Cells[0].Value.ToString();
                tbSupplierID.Text = row.Cells[1].Value.ToString();
                supplieridcheck = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                datetimecheck = row.Cells[2].Value.ToString();
                loaddetailform();
            }
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if(dataGridView2.Rows.Count > 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[index];
                cbproductid.Text = row.Cells[1].Value.ToString();
                lblproductnamevalue.Text = row.Cells[2].Value.ToString();
                lblsoluong.Text = row.Cells[3].Value.ToString();
                tbPrice.Text = row.Cells[4].Value.ToString();
                tbQuantity.Text = row.Cells[5].Value.ToString();
            }    
        }

        private void cbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                lblproductnamevalue.Text = adddetailBLL.Instance.getproductname(cbproductid.Text);
                lblsoluong.Text = adddetailBLL.Instance.getproductamount(cbproductid.Text).ToString();
                tbPrice.Text = "";
                tbQuantity.Text = "";            
        }

    }
}
