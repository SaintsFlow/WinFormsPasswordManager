using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPasswordManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void save()
        {
            if (String.IsNullOrEmpty(passwordName.Text))
            {
                MessageBox.Show("Не указано имя");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        public string getPasswordName()
        {
            return passwordName.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                save();
            }
        }
    }
}
