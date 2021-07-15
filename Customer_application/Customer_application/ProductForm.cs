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
    public partial class ProductForm : Form
    {
        void EndEdit()
        {
            this.xpCollection1.Load();
            this.gridView1.CloseEditor();

        }
        public ProductForm()
        {
            InitializeComponent();
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EndEdit();
            unitOfWork1.CommitChanges();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(textEdit1.EditValue == null)
            {
                textEdit1.EditValue = "";
            }
            else
            {
                CriteriaOperator criteria = new BinaryOperator("ProductCode", "%" + textEdit1.EditValue.ToString() + "%", BinaryOperatorType.Like);
                CriteriaOperator criteria2 = new BinaryOperator("ProductDescription", "%" + textEdit1.EditValue.ToString() + "%", BinaryOperatorType.Like);
                xpCollection1.Criteria = criteria + criteria2;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xpCollection1.Reload();
        }
    }
}
