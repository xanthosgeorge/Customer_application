using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;

namespace Customer_application
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public GroupOperator Criteria
        {
            set { xpCollection1.Criteria = value; }
            get { return (GroupOperator)xpCollection1.Criteria; }
        }
       
        public XtraReport1()
        {
            InitializeComponent();
           
                   
        }

    }
}
