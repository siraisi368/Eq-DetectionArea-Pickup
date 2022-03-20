using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;


namespace Eq_DetectionArea_Pickup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient();

        private void act_telopmv_Tick(object sender, EventArgs e)
        {
            label3.Left += -trackBar1.Value;
            if (label3.Right < 0)
            {

                label3.Left = this.ClientSize.Width - label2.Right;
            }
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 160;
            //this.Height = 80;(元の高さ)
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "現在の速度:" + trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 80;
        }

        private async void act_k24api_Tick(object sender, EventArgs e)
        {
            try
            {
                var uri = "https://kwatch-24h.net/EQLevel.json";
                var json = await client.GetStringAsync(uri);
                var k24 = JsonConvert.DeserializeObject<k24_c>(json);

                var detec_ar = k24.p; //検出地域

                if (detec_ar == null)
                {

                }
                else
                {
                    //地域名を入れる箱
                    string t00 = null;
                    string t01 = null;
                    string t02 = null;
                    string t03 = null;
                    string t04 = null;
                    string t05 = null;
                    string t06 = null;
                    string t07 = null;
                    string t08 = null;
                    string t09 = null;
                    string t10 = null;
                    string t11 = null;
                    string t12 = null;
                    string t13 = null;
                    string t14 = null;
                    string t15 = null;
                    string t16 = null;
                    string t17 = null;
                    string t18 = null;
                    string t19 = null;
                    string t20 = null;
                    string t21 = null;
                    string t22 = null;
                    string t23 = null;
                    string t24 = null;
                    string t25 = null;
                    string t26 = null;
                    string t27 = null;
                    string t28 = null;
                    string t29 = null;
                    string t30 = null;
                    string t31 = null;
                    string t32 = null;
                    string t33 = null;
                    string t34 = null;
                    string t35 = null;
                    string t36 = null;
                    string t37 = null;
                    string t38 = null;
                    string t39 = null;
                    string t40 = null;
                    string t41 = null;
                    string t42 = null;
                    string t43 = null;
                    string t44 = null;
                    string t45 = null;
                    string t46 = null;
                    string t47 = null;
                    //地域名を入れる箱　終

                    //検出地域検索
                    if (detec_ar.Contains("00"))
                    {
                        t00 = "全国 ";
                    }
                    else
                    {
                        t00 = null;
                    }
                    if (detec_ar.Contains("01"))
                    {
                        t01 = "北海道 ";
                    }
                    else
                    {
                        t01 = null;
                    }
                    if (detec_ar.Contains("02"))
                    {
                        t02 = "青森県 ";
                    }
                    else
                    {
                        t02 = null;
                    }
                    if (detec_ar.Contains("03"))
                    {
                        t03 = "岩手県 ";
                    }
                    else
                    {
                        t03 = null;
                    }
                    if (detec_ar.Contains("04"))
                    {
                        t04 = "宮城県 ";
                    }
                    else
                    {
                        t04 = null;
                    }
                    if (detec_ar.Contains("05"))
                    {
                        t05 = "秋田県 ";
                    }
                    else
                    {
                        t05 = null;
                    }
                    if (detec_ar.Contains("06"))
                    {
                        t06 = "山形県 ";
                    }
                    else
                    {
                        t06 = null;
                    }
                    if (detec_ar.Contains("07"))
                    {
                        t07 = "福島県 ";
                    }
                    else
                    {
                        t07 = null;
                    }
                    if (detec_ar.Contains("08"))
                    {
                        t08 = "茨城県 ";
                    }
                    else
                    {
                        t08 = null;
                    }
                    if (detec_ar.Contains("09"))
                    {
                        t09 = "栃木県 ";
                    }
                    else
                    {
                        t09 = null;
                    }
                    if (detec_ar.Contains("10"))
                    {
                        t10 = "群馬県 ";
                    }
                    else
                    {
                        t10 = null;
                    }
                    if (detec_ar.Contains("11"))
                    {
                        t11 = "埼玉県 ";
                    }
                    else
                    {
                        t11 = null;
                    }
                    if (detec_ar.Contains("12"))
                    {
                        t12 = "千葉県 ";
                    }
                    else
                    {
                        t12 = null;
                    }
                    if (detec_ar.Contains("13"))
                    {
                        t13 = "東京都 ";
                    }
                    else
                    {
                        t13 = null;
                    }
                    if (detec_ar.Contains("14"))
                    {
                        t14 = "神奈川県 ";
                    }
                    else
                    {
                        t14 = null;
                    }
                    if (detec_ar.Contains("15"))
                    {
                        t15 = "新潟県 ";
                    }
                    else
                    {
                        t15 = null;
                    }
                    if (detec_ar.Contains("16"))
                    {
                        t16 = "富山県 ";
                    }
                    else
                    {
                        t16 = null;
                    }
                    if (detec_ar.Contains("17"))
                    {
                        t17 = "石川県 ";
                    }
                    else
                    {
                        t17 = null;
                    }
                    if (detec_ar.Contains("18"))
                    {
                        t18 = "福井県 ";
                    }
                    else
                    {
                        t18 = null;
                    }
                    if (detec_ar.Contains("19"))
                    {
                        t19 = "山梨県 ";
                    }
                    else
                    {
                        t19 = null;
                    }
                    if (detec_ar.Contains("20"))
                    {
                        t20 = "長野県 ";
                    }
                    else
                    {
                        t20 = null;
                    }
                    if (detec_ar.Contains("21"))
                    {
                        t21 = "岐阜県 ";
                    }
                    else
                    {
                        t21 = null;
                    }
                    if (detec_ar.Contains("22"))
                    {
                        t22 = "静岡県 ";
                    }
                    else
                    {
                        t22 = null;
                    }
                    if (detec_ar.Contains("23"))
                    {
                        t23 = "愛知県 ";
                    }
                    else
                    {
                        t23 = null;
                    }
                    if (detec_ar.Contains("24"))
                    {
                        t24 = "三重県 ";
                    }
                    else
                    {
                        t24 = null;
                    }
                    if (detec_ar.Contains("25"))
                    {
                        t25 = "滋賀県 ";
                    }
                    else
                    {
                        t25 = null;
                    }
                    if (detec_ar.Contains("26"))
                    {
                        t26 = "京都府 ";
                    }
                    else
                    {
                        t26 = null;
                    }
                    if (detec_ar.Contains("27"))
                    {
                        t27 = "大阪府 ";
                    }
                    else
                    {
                        t27 = null;
                    }
                    if (detec_ar.Contains("28"))
                    {
                        t28 = "兵庫県 ";
                    }
                    else
                    {
                        t28 = null;
                    }
                    if (detec_ar.Contains("29"))
                    {
                        t29 = "奈良県 ";
                    }
                    else
                    {
                        t29 = null;
                    }
                    if (detec_ar.Contains("30"))
                    {
                        t30 = "和歌山県 ";
                    }
                    else
                    {
                        t30 = null;
                    }
                    if (detec_ar.Contains("31"))
                    {
                        t31 = "鳥取県 ";
                    }
                    else
                    {
                        t31 = null;
                    }
                    if (detec_ar.Contains("32"))
                    {
                        t32 = "島根県 ";
                    }
                    else
                    {
                        t32 = null;
                    }
                    if (detec_ar.Contains("33"))
                    {
                        t33 = "岡山県 ";
                    }
                    else
                    {
                        t33 = null;
                    }
                    if (detec_ar.Contains("34"))
                    {
                        t34 = "広島県 ";
                    }
                    else
                    {
                        t34 = null;
                    }
                    if (detec_ar.Contains("35"))
                    {
                        t35 = "山口県 ";
                    }
                    else
                    {
                        t35 = null;
                    }
                    if (detec_ar.Contains("36"))
                    {
                        t36 = "徳島県 ";
                    }
                    else
                    {
                        t36 = null;
                    }
                    if (detec_ar.Contains("37"))
                    {
                        t37 = "香川県 ";
                    }
                    else
                    {
                        t37 = null;
                    }
                    if (detec_ar.Contains("38"))
                    {
                        t38 = "愛媛県 ";
                    }
                    else
                    {
                        t38 = null;
                    }
                    if (detec_ar.Contains("39"))
                    {
                        t39 = "高知県 ";
                    }
                    else
                    {
                        t39 = null;
                    }
                    if (detec_ar.Contains("40"))
                    {
                        t40 = "福岡県 ";
                    }
                    else
                    {
                        t40 = null;
                    }
                    if (detec_ar.Contains("41"))
                    {
                        t41 = "佐賀県 ";
                    }
                    else
                    {
                        t41 = null;
                    }
                    if (detec_ar.Contains("42"))
                    {
                        t42 = "長崎県 ";
                    }
                    else
                    {
                        t42 = null;
                    }
                    if (detec_ar.Contains("43"))
                    {
                        t43 = "熊本県 ";
                    }
                    else
                    {
                        t43 = null;
                    }
                    if (detec_ar.Contains("44"))
                    {
                        t44 = "大分県 ";
                    }
                    else
                    {
                        t44 = null;
                    }
                    if (detec_ar.Contains("45"))
                    {
                        t45 = "宮崎県 ";
                    }
                    else
                    {
                        t45 = null;
                    }
                    if (detec_ar.Contains("46"))
                    {
                        t46 = "鹿児島県 ";
                    }
                    else
                    {
                        t46 = null;
                    }
                    if (detec_ar.Contains("47"))
                    {
                        t47 = "南西諸島 ";
                    }
                    else
                    {
                        t47 = null;
                    }
                    //検出地域検索　終



                    //判定

                    if (detec_ar == null)
                    {
                        act_telopmv.Enabled = false;

                        label1.Text = "地震を検出した地域を表示します。";
                        label3.Text = "";

                        label1.ForeColor = Color.DarkGray;
                        label3.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        label1.ForeColor = Color.Yellow;
                        label3.ForeColor = Color.Yellow;
                        label1.Text = "検知:";
                        label3.Text = $"{t00}{t01}{t02}{t03}{t04}{t05}{t06}{t07}{t08}{t09}{t10}{t11}{t12}{t13}{t14}{t15}{t16}{t17}{t18}{t19}{t20}{t21}{t22}{t23}{t24}{t25}{t26}{t27}{t28}{t29}{t30}{t31}{t32}{t33}{t34}{t35}{t36}{t37}{t38}{t39}{t40}{t41}{t42}{t43}{t44}{t45}{t46}{t47}";

                        string s = label2.Text; //string→string(???????)
                        int len = s.Length; //文字数の取得

                        if (len >= 32)
                        {
                            act_telopmv.Enabled = true; //てろっぷうごかす
                        }
                        else
                        {
                            act_telopmv.Enabled = false; //てろっぷとめる

                            label3.Location = new Point(76, 0); //位置を固定する
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                label2.Text = ex.ToString();
            }
            
        }

        class k24_c
        {
            public string l { get; set; }
            public string g { get; set; }
            public string y { get; set; }
            public string r { get; set; }
            public string t { get; set; }
            public string e { get; set; }
            public string p { get; set; }

        }
    }
}
