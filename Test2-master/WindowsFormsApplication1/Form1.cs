using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CoreTweet.Streaming;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using CoreTweet;

//http://dobon.net/vb/dotnet/programing/displayprogress.html#threadcancel ここを試してみる

//http://kuroeveryday.blogspot.jp/2013/04/ctwitteroauth.html OAuth認証のやつ

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private NotifyIcon notifyIcon1;
        private System.ComponentModel.IContainer components;
        string s3;
        private Button button2;
        int count = 0;


        public Form1()
        {
            InitializeComponent();

            var programs = new[] { "Lv50 ティアマト・マグナ", "Lv70 コロッサス・マグナ", "Lv60 リヴァイアサン・マグナ", "Lv60 ユグドラシル・マグナ", "Lv75 シュバリエ・マグナ", "Lv75 セレスト・マグナ" };
            comboBox1.Items.AddRange(programs);
            comboBox1.SelectedIndex = 0;


            CoreTweet.Tokens tokens = CoreTweet.Tokens.Create("ewtg8suISRPzfZyxWEKwTDoQf"
                , "SoOOnaoylZnjLJu8n4ygMyENW2RQ5QFq1IjdfuUp5A9blr9oKK"
              , "3167038009-tVOk9rSAdYIrdUbcp7LW29Rsidr44UttspFYDFZ"
               , "Xy6yeEU6seLDBvx8UgoEemBXsSY5vZD0kV1WdAFpqtSZl");



            int index = comboBox1.SelectedIndex;
            string Text = comboBox1.Items[index].ToString();

            var result = tokens.Search.TweetsAsync(count => 100, q => Text);

            // tokens.Statuses.Update(new { status = text1 });

          

            //InitializeComponent();
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "a";
            this.notifyIcon1.BalloonTipTitle = "a";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "中止";
            this.button2.Enabled = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public async void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "guraburugo";
            notifyIcon1.BalloonTipText = "監視を開始しました";
            notifyIcon1.ShowBalloonTip(3000);
            button1.Enabled = false;
            button2.Enabled = true;
            //Task.Run(
           
               
            CoreTweet.Tokens tokens = CoreTweet.Tokens.Create("ewtg8suISRPzfZyxWEKwTDoQf"
                , "SoOOnaoylZnjLJu8n4ygMyENW2RQ5QFq1IjdfuUp5A9blr9oKK"
              , "3167038009-tVOk9rSAdYIrdUbcp7LW29Rsidr44UttspFYDFZ"
               , "Xy6yeEU6seLDBvx8UgoEemBXsSY5vZD0kV1WdAFpqtSZl");
            for (int g = 0; g <= 10000; g++)
            {

               
                string ret = await AsyncTask();
                /*  int index = comboBox1.SelectedIndex;

                      string Text = comboBox1.Items[index].ToString();

                 // for (int i=0; i <= 10000; i++)
                  //{
                  var t =Task.Run(() =>
       {
           return   tokens.Streaming.Filter(track => Text)
                   .OfType<StatusMessage>()
                   .Select(x => x.Status)
                   .Take(1);
       });


                      foreach (var tweet in t.Result) 
                      {
                          label1.Text = string.Format("{0}: {1}",
                  tweet.User.ScreenName, tweet.Text);

                          string s3 = string.Format(tweet.Text);

                          Clipboard.SetDataObject(s3.Substring(11, 8));
                          //test

                      }
                  //}
                  */

                /*
                                var stream = tokens.Streaming.UserAsObservable().Publish();

                                stream.OfType<StatusMessage>()
                                    .Subscribe(x => Console.WriteLine("{0}: {1}", x.Status.User.ScreenName, x.Status.Text));

                                var disposable = stream.Connect();

                                await Task.Delay(30 * 1000);
                                disposable.Dispose();*/


                label1.Text = s3;



                //通常の文章で58文字
                int len = s3.Length;

                Clipboard.SetDataObject(s3.Substring(len - 47, 8));
                

                //test
                notifyIcon1.BalloonTipTitle = "guraburugo";
                notifyIcon1.BalloonTipText = s3;
                notifyIcon1.ShowBalloonTip(3000);
            }
            
        }
        public async Task<string> AsyncTask()
        {

            
            CoreTweet.Tokens tokens = CoreTweet.Tokens.Create("ewtg8suISRPzfZyxWEKwTDoQf"
                    , "SoOOnaoylZnjLJu8n4ygMyENW2RQ5QFq1IjdfuUp5A9blr9oKK"
                  , "3167038009-tVOk9rSAdYIrdUbcp7LW29Rsidr44UttspFYDFZ"
                   , "Xy6yeEU6seLDBvx8UgoEemBXsSY5vZD0kV1WdAFpqtSZl");
            
            int index = comboBox1.SelectedIndex;

            string Text = comboBox1.Items[index].ToString();

            Func<string> asyncJob = () =>
            {

                
              
                Thread.Sleep(5000);
                foreach (var m in tokens.Streaming.Filter(track => Text)
                         .OfType<StatusMessage>()
                         .Select(x => x.Status)
                         .Take(1))
                {

                    s3 = m.Text;

                }
               

                // 時間のかかる処理事
                /*  var m = tokens.Streaming.Filter(track => Text)
                 .OfType<StatusMessage>()
                 .Select(x => x.Status)
                 .Take(1);*/

                return s3;
            };
            
            
            string ret = await Task.Run(asyncJob);
            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
            button1.Enabled = true;

        }

       
        //コントロールの値を変更する
      /*  private void SetProgressValue(int num)
        {
            //ProgressBar1の値を変更する
            ProgressBar1.Value = num;
            //Label1のテキストを変更する
            Label1.Text = num.ToString();
        }*/

        //処理が完了した時にコントロールの値を変更する
        private void ThreadCompleted()
        {

        }

        //処理がキャンセルされた時にコントロールの値を変更する
        private void ThreadCanceled()
        {
            label1.Text = "キャンセルされました。";
            button1.Enabled = true;
            button2.Enabled = false;
        }

    }



    // class Program
    //  {
    //     public static void Main(string[] args)
    //     {
    //         var tokens = CoreTweet.Tokens.Create("ewtg8suISRPzfZyxWEKwTDoQf"
    //             , "SoOOnaoylZnjLJu8n4ygMyENW2RQ5QFq1IjdfuUp5A9blr9oKK"
    //           , " 3167038009-tVOk9rSAdYIrdUbcp7LW29Rsidr44UttspFYDFZ"
    //            , "Xy6yeEU6seLDBvx8UgoEemBXsSY5vZD0kV1WdAFpqtSZl");

    //        var text = "status text";
    //        tokens.Statuses.Update(new { status = text });
    //    }
    // }


}