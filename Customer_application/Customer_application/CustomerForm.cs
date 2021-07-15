using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        void EndEdit()
        {
            this.xpCollection1.Load();
            this.gridView1.CloseEditor();

        }

       

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Point pt = gridControl1.PointToClient(MousePosition);
            GridHitInfo hitinfo = gridView1.CalcHitInfo(pt);
            if (!hitinfo.InRow) return;
            Customer cc = (Customer)gridView1.GetRow(hitinfo.RowHandle);
            OrderForm ordf = new OrderForm(cc);
            ordf.ShowDialog();
        }

        

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
             if (textEdit1.EditValue==null)
            {
                textEdit1.EditValue = "";
            }
            else
            {
                CriteriaOperator criteria = new BinaryOperator("CustomerName", "%" + textEdit1.EditValue.ToString() + "%", BinaryOperatorType.Like);
                xpCollection1.Criteria = criteria;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            EndEdit();
            unitOfWork1.CommitChanges();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xpCollection1.Reload();
        }

         
        }

        
    }

