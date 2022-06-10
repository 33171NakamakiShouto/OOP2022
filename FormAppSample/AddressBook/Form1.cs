using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void label3_Click(object sender, EventArgs e){ }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
            
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);    
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();

            if (cbFamiy.Checked)
            {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked)
            {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked)
            {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked)
            {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbName.Text = listPerson[0].Name;
            var select = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[select].Name;
            tbMailAddress.Text = listPerson[select].MailAddress;
            tbAddress.Text = listPerson[select].Address;
            tbCompany.Text = listPerson[select].Company;
            pbPicture.Image = listPerson[select].Picture;

            cbFamiy.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;

            foreach (var group in listPerson[select].listGroup)
            {
                switch (group)
                {
                    case Person.GroupType.家族:
                        cbFamiy.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }
       


        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void dgvPersons_Click(object sender, EventArgs e){}
    }
}
