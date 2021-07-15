using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Customer_application
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm<CustomerForm>();
        }

        void ShowForm<Tform>() where Tform : Form, new() //default constructor
        {
            var instance = this.MdiChildren.OfType<Tform>().FirstOrDefault();
            if (instance != null)
            {
                instance.Activate();
            }
            else
            {
                instance = new Tform();
                instance.MdiParent = this;
                instance.WindowState = FormWindowState.Maximized;
                instance.Show();
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm<ProductTypeForm>();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm<ProductForm>();
        }

        private void ReportButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //    XtraReport1 report = new XtraReport1();
            //    var reportTool = new ReportPrintTool(report);
            //    reportTool.ShowRibbonPreview();
            //}
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm<CriteriaForm>();
        }

       
    }
}
