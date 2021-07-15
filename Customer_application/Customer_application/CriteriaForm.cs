using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;

namespace Customer_application
{
    public partial class CriteriaForm : Form
    {
        public CriteriaForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GroupOperator criteria = new GroupOperator();
            criteria.OperatorType = GroupOperatorType.And;
            criteria.Operands.Add(new BinaryOperator("Customer.CustomerName", "%" + textEdit1.EditValue.ToString() + "%", BinaryOperatorType.Like));
            if (lookUpEdit1.EditValue!=null)
                criteria.Operands.Add(new BinaryOperator("Product.Oid", lookUpEdit1.EditValue, BinaryOperatorType.Equal));
            if (dateEdit1.EditValue != null)
                criteria.Operands.Add(new BinaryOperator("OrderDate", (DateTime)dateEdit1.EditValue, BinaryOperatorType.GreaterOrEqual));
            if (dateEdit2.EditValue != null)
                criteria.Operands.Add(new BinaryOperator("OrderDate", (DateTime)dateEdit2.EditValue, BinaryOperatorType.LessOrEqual));
            XtraReport1 report = new XtraReport1();
            report.Criteria = criteria;
            var reportTool = new ReportPrintTool(report);
            reportTool.ShowRibbonPreview();         
        }

        private void CriteriaForm_Load(object sender, EventArgs e)
        {
            textEdit1.EditValue = "";
           
        }
    }
}
