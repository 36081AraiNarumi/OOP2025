namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            btGoFoward = new Button();
            btGoback = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            cbUrl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(533, 56);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(94, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(12, 159);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(607, 109);
            lbTitles.TabIndex = 2;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(12, 282);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(607, 373);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            // 
            // btGoFoward
            // 
            btGoFoward.Location = new Point(12, 64);
            btGoFoward.Name = "btGoFoward";
            btGoFoward.Size = new Size(75, 23);
            btGoFoward.TabIndex = 4;
            btGoFoward.Text = "進む";
            btGoFoward.UseVisualStyleBackColor = true;
            // 
            // btGoback
            // 
            btGoback.Location = new Point(93, 64);
            btGoback.Name = "btGoback";
            btGoback.Size = new Size(75, 23);
            btGoback.TabIndex = 4;
            btGoback.Text = "戻る";
            btGoback.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(25, 106);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 6;
            label1.Text = "お気に入り登録";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 7;
            label2.Text = "URL又はお気に入り名称";
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(523, 112);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "登録";
            button3.UseVisualStyleBackColor = true;
            // 
            // cbUrl
            // 
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(255, 84);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(121, 23);
            cbUrl.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 667);
            Controls.Add(cbUrl);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btGoback);
            Controls.Add(btGoFoward);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "RSSリーダー";
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUrl;
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button btGoback;
        private Button btGoFoward;
        private ComboBox comboBox1;
        private ComboBox cbUrl;
    }
}
