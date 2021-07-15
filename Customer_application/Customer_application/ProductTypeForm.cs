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
    public partial class ProductTypeForm : Form
    {
        public ProductTypeForm()
        {
            InitializeComponent();
        }
        public void EndEdit()
        {
            this.xpCollection1.Load();
            this.gridView1.CloseEditor();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            this.xpCollection1.Reload();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EndEdit();
            unitOfWork1.CommitChanges();
        }
    }
}
