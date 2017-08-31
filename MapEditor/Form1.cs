using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    //数値等設定用のフォームです
    public partial class SetStatus : Form
    {
        String filetype = "null";

        private MainEdit mainForm;

        public SetStatus()
        {
            InitializeComponent();
            //mainForm = new MainEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetStatus_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //読み込みファイル設定
            OpenFileDialog spriteFileDialog = new OpenFileDialog();
            spriteFileDialog.Filter = "スプライトファイル(*.png)|*.png|マップデータ(*.csv)|*.csv";
            spriteFileDialog.Title = "開くファイルを選択";
            spriteFileDialog.CheckFileExists = true;
            spriteFileDialog.CheckPathExists = true;
            if(spriteFileDialog.ShowDialog()== DialogResult.OK)
            {
                label5.Text = spriteFileDialog.FileName;
                filetype = System.IO.Path.GetExtension(spriteFileDialog.FileName);
                if(filetype==".png")
                {
                    label6.Text = "スプライトファイルが選択されました";
                }
                else if(filetype==".csv")
                {
                    label6.Text = "既存マップデータが選択されました";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(filetype=="null")
            {
                //ファイル選択エラー!ファイルを選択せずにボタンをクリックしています
                MessageBox.Show("ファイルを選択しろっつったろ", "ファイル未選択", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(filetype != ".png"&&filetype != ".csv")
            {
                //ファイル選択エラー!どうやらおかしな手段でおかしなファイルを選択しています
                MessageBox.Show("変なファイル選んでんじゃねぇぞ", "拡張子が違います", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //エディット開始。エディタ画面へ移動します
                int XNum = int.Parse(textBox1.Text);
                int YNum = int.Parse(textBox2.Text);
                mainForm = new MainEdit(label5.Text, filetype, XNum, YNum);
                Hide();
                mainForm.ShowDialog(this);
                //メインエディタフォームを閉じると以下のコードが実行
                mainForm.Dispose();
                Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
