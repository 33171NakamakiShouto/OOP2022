using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AddressBook.Person;

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

        private void label3_Click(object sender, EventArgs e) { }

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
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                KindNumber = GetRadioButtonGroup(),
                TelNumber = tbTelephoneNumber.Text,
                Registration = dtpRegistDate.Value,
            };

            setcbCompany(cbCompany.Text);

            listPerson.Add(newPerson);
            AllDelete();
            btdelete.Enabled = true;
            btUpdate.Enabled = true;

                      
        }

        private void setcbCompany(string company)
        {
            if (cbCompany.Items.IndexOf(cbCompany.Text) == -1)
            {
                cbCompany.Items.Add(cbCompany.Text);
            }
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

        private Person.KindNumberType GetRadioButtonGroup()
        {
            var selectKindNumber = Person.KindNumberType.その他;

            if (rbCellPhone.Checked)
            {
                return Person.KindNumberType.携帯;
            }
            if (rbHome.Checked)
            {
                return Person.KindNumberType.自宅;
            }

            return selectKindNumber;
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

            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;
            tbTelephoneNumber.Text = listPerson[index].TelNumber;
            

            dtpRegistDate.Value = listPerson[index].Registration.Year > 1900 ? 
                listPerson[index].Registration : DateTime.Today;

            groupCheckBoxAllClear();
            groupRadioButtonAllClear();

            groupCheckBoxAllUpdate();
            groupRadioButtonAllUpdate();
        }

        private void groupCheckBoxAllClear()
        {
            cbFamiy.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }
        private void groupRadioButtonAllClear()
        {
            rbCellPhone.Checked = rbHome.Checked = false;
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

        private void groupRadioButtonAllUpdate()
        {
            var select = dgvPersons.CurrentRow.Index;
            switch (listPerson[select].KindNumber)
            {
                case KindNumberType.自宅:
                    rbHome.Checked = true;
                    break;
                case KindNumberType.携帯:
                    rbCellPhone.Checked = true;
                    break;
                case KindNumberType.その他:
                    break;
                default:
                    break;
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
            listPerson[select].Company = cbCompany.Text;
            listPerson[select].listGroup = GetCheckBoxGroup();
            listPerson[select].Picture = pbPicture.Image;
            listPerson[select].TelNumber = tbTelephoneNumber.Text;
            listPerson[select].KindNumber = GetRadioButtonGroup();
            dgvPersons.Refresh();//データグリッドビュー更新
            EnadledCheck();
            AllDelete();           
        }

        //削除ボタンを押された時の処理
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            EnadledCheck();
        }

        private void AllDelete()
        {
            tbName.Text =tbMailAddress.Text = tbAddress.Text = cbCompany.Text = tbTelephoneNumber.Text="";
            pbPicture.Image = null;
            groupCheckBoxAllClear();
            rbHome.Checked = rbCellPhone.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            btdelete.Enabled = false;
            btUpdate.Enabled = false;
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //開くボタンのイベントハンドラ
        private void btOpen_Click(object sender, EventArgs e)
        {

            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cbCompany.Items.Clear();

                foreach (var item in listPerson.Select(p => p.Company))
                {
                    setcbCompany(item);
                }

                EnadledCheck();

            }
        }

        //更新・削除ボタンのマスク処理
        private void EnadledCheck()
        {
            btUpdate.Enabled = btdelete.Enabled = listPerson.Count() > 0 ? true : true;
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e){}       
        private void dgvPersons_Click(object sender, EventArgs e){}
        private void btOpen_Click_1(object sender, EventArgs e){}
        private void sfdSaveDialog_FileOk(object sender, CancelEventArgs e){}
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e){}
        private void tbMailAddress_TextChanged(object sender, EventArgs e){}
        private void rbHome_CheckedChanged(object sender, EventArgs e){}
        private void gbKindNumber_Enter(object sender, EventArgs e){}
    }
}
