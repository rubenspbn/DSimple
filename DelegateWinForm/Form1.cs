using DelegateWinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateWinForm
{
    //public delegate string PersonFormat(Person input);
    public partial class Form1 : Form
    {
        Func<Person,string> proc;
        public Form1()
        {
            InitializeComponent();
            lbxPeople.DataSource = People.GetPeople().ToList();
        }
        private void AssignToDelegate()
        {
            if (rbtnDefault.Checked) proc = Formatter.Default;
            else if (rbtnFirstName.Checked) proc = Formatter.FirstNameToUpper;
            else if (rbtnLastName.Checked) proc = Formatter.LastNameToUpper;
            else if (rbtnFullName.Checked) proc = Formatter.FullNameToUpper;
            else proc = Formatter.Default;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lbxPeople.DataSource = null;
            lbxPeople.Items.Clear();
            AssignToDelegate();
            foreach (var item in People.GetPeople())
            {
                lbxPeople.Items.Add(item.ToString(proc));
            }
        }
    }
}
