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
    public partial class MainEdit : Form
    {
        //メインエディター画面です

        private MapChips mapChip;

        private int XNum, YNum;

        public MainEdit(string path,string type,int X,int Y)
        {
            InitializeComponent();
            mapChip = new MapChips(path,type);
            XNum = X;
            YNum = Y;
            this.labelX.Text = "幅"+XNum.ToString();
            this.labelY.Text = "高さ" + YNum.ToString();
        }

        private void MainEdit_Load(object sender, EventArgs e)
        {
            mapChip.Show(this);
        }

        private void MainEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MainEdit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
