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

        //追加ボタンを押された時の処理
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
            AllDelete();
            btdelete.Enabled = true;
            btUpdate.Enabled = true;
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
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentRow.Index;

            //tbName.Text = listPerson[0].Name;
            var select = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[select].Name;
            tbMailAddress.Text = listPerson[select].MailAddress;
            tbAddress.Text = listPerson[select].Address;
            tbCompany.Text = listPerson[select].Company;
            pbPicture.Image = listPerson[select].Picture;
         
            groupCheckBoxAllClear();
            groupCheckBoxAllUpdate();


        }

        private void groupCheckBoxAllClear()
        {
            cbFamiy.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void groupCheckBoxAllUpdate()
        {
            var select = dgvPersons.CurrentRow.Index;
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

        //更新ボタンを押された時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;

            var select = dgvPersons.CurrentRow.Index;
            listPerson[select].Name = tbName.Text;
            listPerson[select].MailAddress = tbMailAddress.Text;
            listPerson[select].Address = tbAddress.Text;
            listPerson[select].Company = tbCompany.Text;
            listPerson[select].listGroup = GetCheckBoxGroup();
            listPerson[select].Picture = pbPicture.Image;
            dgvPersons.Refresh();//データグリッドビュー更新
            AllDelete();           
        }

        //削除ボタンを押された時の処理
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            if (listPerson.Count == 0)
            {
                btdelete.Enabled = false;
                btUpdate.Enabled = false;
            }
        }

        private void AllDelete()
        {
            tbName.Text =tbMailAddress.Text = tbAddress.Text = tbCompany.Text = "";
            pbPicture.Image = null;
            groupCheckBoxAllClear();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            btdelete.Enabled = false;
            btUpdate.Enabled = false;
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e){}       
        private void dgvPersons_Click(object sender, EventArgs e){}


    }
}
