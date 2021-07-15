using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_application
{
    public partial class OrderForm : Form
    {
        Customer ccc = new Customer();
        public OrderForm(Customer cc)
        {
            InitializeComponent();
            ccc = cc;
            int search = ccc.Oid;
            xpCollection1.Load();
            CriteriaOperator criteria = new BinaryOperator("Oid", search, BinaryOperatorType.Equal);
            xpCollection1.Criteria = criteria;
            xpCollection1.Reload();
        }

      
        void EndEdit()
        {
            this.xpCollection1.Load();
            this.gridView1.CloseEditor();

        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EndEdit();
            unitOfWork1.CommitChanges();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            xpCollection1.Reload();
        }
    }

}
