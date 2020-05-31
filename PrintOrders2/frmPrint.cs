using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintOrders2
{
    public partial class frmPrint : Form
    {
         List<OrderDetail> _list;
       Orders _orders;

        public frmPrint(Orders orders, List<OrderDetail> list )
        {
            InitializeComponent();
            _list = list;
            _orders = orders;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            rptOrder1.SetDataSource(_list); 
            rptOrder1.SetParameterValue("pOrderID", _orders.OrderID);
            rptOrder1.SetParameterValue("pAddress", _orders.Address);
            rptOrder1.SetParameterValue("pContactName", _orders.ContactName);
            rptOrder1.SetParameterValue("pDate", _orders.OrderDate);
            rptOrder1.SetParameterValue("pCity", _orders.City);
            rptOrder1.SetParameterValue("pPhone", _orders.Phone);
            rptOrder1.SetParameterValue("pPostal", _orders.PostalCode);
            
            crystalReportViewer1.ReportSource = rptOrder1;
            crystalReportViewer1.Refresh();
        }
    }
}
