using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocTorHouseManger
{
    public partial class ChangeTableName : Form
    {
        public ChangeTableName()
        {
            InitializeComponent();
        }
        public string TableName { get => textEdit1.Text; set => textEdit1.Text = value; }
        
        public bool enforce = false;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == null)
            {
                MessageBox.Show("Tên Bảng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                enforce = true;
                this.Close();
            }
            
        }
        
    }
}
