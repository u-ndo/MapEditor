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
    //読み込んだスプライトからマップチップを個別に表示します
    public partial class MapChips : Form
    {
        //定数宣言　改造したいときはここをいじってね
        public const int CHIPSIZE = 64;     //マップチップ一つのサイズ(Pixel)
        public const int D_CHIPSIZE = 32;   //マップチップを表示するサイズ(Pixel)
        public const int MARGIN = 12;       //マップチップ塊の画面端からの表示間隔(Pixel)
        public const int INTERVAL = 5;      //マップチップの表示間隔(Pixel)
        public const int CHIPNUM = 4;       //マップチップのデフォルト表示数(推奨初期設定4)
        public const int HOSEI = 22;        //表示領域とフォームサイズの補正(多分これを足せばうまくいく)

        //スプライト画像へのパス
        string path;

        //スプライト画像を格納
        private Bitmap sprite;

        //スプライトの画像の分割数
        int yokoNum,tateNum,spriteNum;

        private PictureBox[] sprites;

        private Bitmap[] canvas;

        private Rectangle[] srcRect;

        public MapChips(string str,string type)
        {
            InitializeComponent();
            path = str;
            if (type==".png")
            {
                //パスを引数にとってスプライトのパスを指定
                sprite = new Bitmap(Image.FromFile(path));
                //スプライトの分割数をセット
                yokoNum = sprite.Width / CHIPSIZE;
                tateNum = sprite.Height / CHIPSIZE;
                spriteNum = yokoNum * tateNum;

                canvas = new Bitmap[spriteNum];
                srcRect = new Rectangle[spriteNum];

                int counter = 0;

                //スプライトを分割
                for(int i=0;i< tateNum; i++)    //縦方向のループ
                {
                    for (int j=0;j<yokoNum;j++)  //横方向のループ
                    {
                        srcRect[counter] = new Rectangle(j*CHIPSIZE, i*CHIPSIZE, CHIPSIZE, CHIPSIZE);
                        counter++;
                    }
                }

                //スプライト分割数でPictureBoxインスタンスの配列を宣言
                this.sprites = new PictureBox[spriteNum];
            }
            else//(type==".csv")
            {

            }
            //このフォームを単独で閉じられないようにする
            this.ControlBox = !this.ControlBox;
        }

        private void MapChips_Load(object sender, EventArgs e)
        {
            for(int i=0;i<this.sprites.Length;i++)
            {
                //インスタンス生成
                this.sprites[i] = new PictureBox();
                //プロパティ設定
                this.sprites[i].Name = i.ToString();    //この数字がそのままスプライトの番号になります
                this.sprites[i].Size = new Size(D_CHIPSIZE, D_CHIPSIZE);
                this.sprites[i].SizeMode= PictureBoxSizeMode.Zoom;
                //イベントハンドラ登録
                this.sprites[i].Click += new EventHandler(this.sprites_Click);
                //表示部分設定
                canvas[i] = new Bitmap(CHIPSIZE, CHIPSIZE);
                Graphics g = Graphics.FromImage(canvas[i]);
                Rectangle desRect = new Rectangle(0, 0, srcRect[i].Width, srcRect[i].Height);
                g.DrawImage(sprite, desRect, srcRect[i], GraphicsUnit.Pixel);
                this.sprites[i].Image = canvas[i];
                g.Dispose();
            }
        }

        private void MapChips_ResizeEnd(object sender, EventArgs e)
        {
            int tateCount = 1, yokoCount = 1;
            for (int i = 0; i < sprites.Length; i++)
            {
                if (i == 0)
                {
                    this.sprites[i].Location = new Point(MARGIN, MARGIN);
                }
                else//i!=0
                {
                    if (this.sprites[i - 1].Location.X + D_CHIPSIZE + INTERVAL > this.Width - MARGIN - HOSEI)
                    {
                        tateCount++;
                    }
                    if (tateCount == 1)
                    {
                        this.sprites[i].Location = new Point(MARGIN + i * (D_CHIPSIZE + INTERVAL), MARGIN);
                        yokoCount++;
                    }
                    else//tateCount!=1
                    {
                        this.sprites[i].Location = new Point(MARGIN + (i % yokoCount) * (D_CHIPSIZE + INTERVAL), MARGIN + (D_CHIPSIZE + INTERVAL) * (tateCount - 1));
                    }
                }
                this.Controls.Add(this.sprites[i]);
            }
        }

        private void sprites_Click(object sender, EventArgs e)
        {
            //クリックされたスプライトの番号をMainEditorの方に渡します
            //テスト
            Console.WriteLine(((PictureBox)sender).Location);

        }

        private void MapChips_Shown(object sender, EventArgs e)
        {
            //初期設定では横に四つ表示
            this.Width = MARGIN * 2 + D_CHIPSIZE * 4+INTERVAL *3+ HOSEI;

            int tateCount=1,yokoCount=1;
            for(int i=0;i<sprites.Length;i++)
            {
                if(i==0)
                {
                    this.sprites[i].Location = new Point(MARGIN,MARGIN);
                }
                else//i!=0
                {
                    if (this.sprites[i-1].Location.X+D_CHIPSIZE+INTERVAL>this.Width-MARGIN-HOSEI)
                    {
                        tateCount++;
                    }
                    if(tateCount==1)
                    {
                        this.sprites[i].Location = new Point(MARGIN+ i*(D_CHIPSIZE + INTERVAL), MARGIN);
                        yokoCount++;
                    }
                    else//tateCount!=1
                    {
                        this.sprites[i].Location = new Point(MARGIN + (i%yokoCount) * (D_CHIPSIZE + INTERVAL), MARGIN+ (D_CHIPSIZE + INTERVAL)*(tateCount-1));
                    }
                }
                this.Controls.Add(this.sprites[i]);
            }

        }
    }
}
