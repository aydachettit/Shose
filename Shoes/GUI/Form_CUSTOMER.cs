using Shoes.DAL;
using Shoes.DTO;
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

namespace Shoes.GUI
{
    public partial class Form_CUSTOMER : Form
    {
        string CustomerIdcheck;
        int index;
        public Form_CUSTOMER()
        {
            InitializeComponent();

        }
        
        public void loadform()
        {
          
            rdBNam.Checked = false;
            rdBNu.Checked = false;
            dgvCustomer.DataSource = customerBLL.Instance.getcustomerlist();
            lblNumCustomer.Text = customerBLL.Instance.getnumcustomer();
            lblNumMale.Text = customerBLL.Instance.getnummale();
            lblNumFemale.Text = customerBLL.Instance.getnumfemale();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(customerBLL.Instance.checkinsert(tbCustomerId.Text,tbCustomerName.Text,CBGender.Text,tbCustomerPhone.Text) == 1)
            {
                tbCustomerId.Text = "";
            }
            loadform();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerIdcheck == tbCustomerId.Text) {
                customerBLL.Instance.checkupdate(tbCustomerId.Text,tbCustomerName.Text,CBGender.Text,tbCustomerPhone.Text);
            }
            else
            {
                MessageBox.Show("Không được thay đổi Id khách hàng!");
                tbCustomerId.Text = CustomerIdcheck;
            }
            loadform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerBLL.Instance.deletecustomer(tbCustomerId.Text);
            loadform();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbSearch.Text;
            if (customerBLL.Instance.checkId(id) == 1)
            {
                dgvCustomer.DataSource = customerBLL.Instance.search(id);
            }
            else
            {
                MessageBox.Show("Mã Id không hợp lệ! Hãy chỉnh sửa.");
                tbSearch.Text = "";
            }
        }
        private void rdBNam_CheckedChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = customerBLL.Instance.getmalelist();
        }

        private void rdBNu_CheckedChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = customerBLL.Instance.getfemalelist();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            loadform();
            tbCustomerId.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPhone.Text = "";
            CBGender.Text = "-------------Chọn giới tính---------------";
            tbSearch.Text = "";
        }
        private void Form_CUSTOMER_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void dgvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomer.Rows.Count > 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = dgvCustomer.Rows[index];
                CustomerIdcheck = row.Cells[0].Value.ToString();
                tbCustomerId.Text = row.Cells[0].Value.ToString();
                tbCustomerName.Text = row.Cells[1].Value.ToString();
                CBGender.Text = customerBLL.Instance.generateGenderfromBIT(Convert.ToInt32(row.Cells[2].Value));
                tbCustomerPhone.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
