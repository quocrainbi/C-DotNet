using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiDotNet.DAO;

namespace ThiDotNet.View
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }
        void LoadListBillByDate(DateTime checkin,DateTime checkout)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkin, checkout);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
    }
}
