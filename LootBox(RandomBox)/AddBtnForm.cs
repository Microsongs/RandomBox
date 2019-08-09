﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootBox_RandomBox_
{
    public partial class AddBtnForm : Form
    {
        private int selected = 0;
        private string imgFileName;
        mainWindow main;
        public AddBtnForm()
        {
            InitializeComponent();
        }
        public AddBtnForm(int selected, mainWindow main)
        {
            InitializeComponent();
            this.selected = selected;
            this.main = main;
            nameTextbox.MaxLength = 20;
            addInit();
        }
        private void addInit()
        {
            // English
            if(selected == 0)
            {
                dataInputLabel.Text = "Enter data";
                nameLabel.Text = "Name：";
                probabilityLabel.Text = "Prob : ";
                imageLabel.Text = "Image : ";
                imageButton.Text = "Load";
                saveButton.Text = "Save";
            }
            // 한국어
            else if(selected == 1)
            {
                dataInputLabel.Text = "데이터 입력";
                nameLabel.Text = "이름 : ";
                probabilityLabel.Text = "확률 : ";
                imageLabel.Text = "이미지 : ";
                imageButton.Text = "등록";
                saveButton.Text = "저장";
            }
            // 日本語
            else
            {
                dataInputLabel.Text = "データを追加";
                nameLabel.Text = "名前 : ";
                probabilityLabel.Text = "確率 : ";
                imageLabel.Text = "イメージ : ";
                imageButton.Text = "登録";
                saveButton.Text = "サーブ";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string imgFile = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgFile = dialog.FileName;
            }
            else if(dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                imagePictureBox.Image = Bitmap.FromFile(imgFile);
                imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imgFileName = System.IO.Path.GetFileName(imgFile);
            }
            catch(Exception ex)
            {
                if(selected == 0)
                {
                    MessageBox.Show("Please load Image File!", "Error!");
                }
                else if(selected == 1)
                {
                    MessageBox.Show("이미지 파일을 불러오세요!", "불러오기 오류!");
                }
                else
                {
                    MessageBox.Show("イメージファイルをアップロードください。", "ロードエラー!");
                }
            }
            
        }

        private bool noInputCheck()
        {
            // 제목 유무 확인
            if (nameTextbox.TextLength == 0)
            {
                if (selected == 0)
                {
                    MessageBox.Show("Name Please!", "Error!");
                }
                else if (selected == 1)
                {
                    MessageBox.Show("이름을 넣어주세요을 불러오세요!", "이름 오류!");
                }
                else
                {
                    MessageBox.Show("名前を入れてください。", "エラー!");
                }
                return false;
            }
            // 20바이트 초과 유무 확인
            else if(Encoding.Default.GetBytes(nameTextbox.Text).Length > 20)
            {
                if (selected == 0)
                {
                    MessageBox.Show("Please enter no more than 20 characters!", "Error!");
                }
                else if (selected == 1)
                {
                    MessageBox.Show("20자 이하로 넣어주세요.", "글자크기 오류!");
                }
                else
                {
                    MessageBox.Show("20文字以下で入力してください。", "エラー!");
                }
                return false;
            }
            // 확률 입력 확인
            else if (probabilityTextbox.TextLength == 0)
            {
                if (selected == 0)
                {
                    MessageBox.Show("Please input the number!", "Error!");
                }
                else if (selected == 1)
                {
                    MessageBox.Show("숫자를 정확히 넣어주세요", "숫자 오류!");
                }
                else
                {
                    MessageBox.Show("数字を正しく入力ください。", "エラー!");
                }
                return false;
            }
            else
                return true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string img_folder = @"../../images";
            LootItem lootitem;

            // 저장 경로가 없을경우 생성
            if (!System.IO.Directory.Exists(img_folder))
                System.IO.Directory.CreateDirectory(img_folder);
            if (!noInputCheck())
                return;

            if (imgFileName == null)
            {
                lootitem = new LootItem(nameTextbox.Text,decimal.Parse(probabilityTextbox.Text));
                main.AddItem(lootitem);
            }
            else
            {
                imagePictureBox.Image.Save(img_folder + "\\" + imgFileName+".jpg");
                Image image = Bitmap.FromFile(img_folder + "\\" + imgFileName +".jpg");
                Bitmap newSize = new Bitmap(image, new Size(35,35));
                lootitem = new LootItem(nameTextbox.Text, newSize, decimal.Parse(probabilityTextbox.Text));
                main.AddItem(lootitem);
            }
            this.Close();
        }

        private void ProbabilityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
