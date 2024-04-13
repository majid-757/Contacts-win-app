using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {

        }

        bool ValidateInputs()
        {
            bool isValid = true;
            if(txtName.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفا نام را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return isValid;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {

            }
        }
    }
}
