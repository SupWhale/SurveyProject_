namespace ProjectSurvey
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question_PushButton = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CountList_SelectBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Number_SelectBox = new System.Windows.Forms.TextBox();
            this.Content_SelcetBox = new System.Windows.Forms.TextBox();
            this.Count_SelectBox = new System.Windows.Forms.ComboBox();
            this.Type_SelectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ttitle_SelectBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question_PushButton
            // 
            this.Question_PushButton.Location = new System.Drawing.Point(1305, 442);
            this.Question_PushButton.Name = "Question_PushButton";
            this.Question_PushButton.Size = new System.Drawing.Size(109, 42);
            this.Question_PushButton.TabIndex = 0;
            this.Question_PushButton.Text = "문항 생성";
            this.Question_PushButton.UseVisualStyleBackColor = true;
            this.Question_PushButton.Click += new System.EventHandler(this.Question_PushButton_Click);
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(279, 863);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(87, 23);
            this.Prev.TabIndex = 0;
            this.Prev.Text = "이전 페이지";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 863);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "다음 페이지";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(862, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "문항 테이블 생성";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(49, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 819);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 793);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "프로그램 사용방법";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 868);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CountList_SelectBox
            // 
            this.CountList_SelectBox.Location = new System.Drawing.Point(1002, 172);
            this.CountList_SelectBox.Name = "CountList_SelectBox";
            this.CountList_SelectBox.Size = new System.Drawing.Size(412, 21);
            this.CountList_SelectBox.TabIndex = 21;
            this.CountList_SelectBox.TextChanged += new System.EventHandler(this.CountList_SelectBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "문항 번호 작성";
            // 
            // Number_SelectBox
            // 
            this.Number_SelectBox.Location = new System.Drawing.Point(902, 78);
            this.Number_SelectBox.Name = "Number_SelectBox";
            this.Number_SelectBox.Size = new System.Drawing.Size(81, 21);
            this.Number_SelectBox.TabIndex = 19;
            this.Number_SelectBox.TextChanged += new System.EventHandler(this.Number_SelectBox_TextChanged);
            // 
            // Content_SelcetBox
            // 
            this.Content_SelcetBox.Location = new System.Drawing.Point(1002, 220);
            this.Content_SelcetBox.Multiline = true;
            this.Content_SelcetBox.Name = "Content_SelcetBox";
            this.Content_SelcetBox.Size = new System.Drawing.Size(412, 195);
            this.Content_SelcetBox.TabIndex = 17;
            this.Content_SelcetBox.TextChanged += new System.EventHandler(this.Content_SelcetBox_TextChanged);
            // 
            // Count_SelectBox
            // 
            this.Count_SelectBox.FormattingEnabled = true;
            this.Count_SelectBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Count_SelectBox.Location = new System.Drawing.Point(1293, 126);
            this.Count_SelectBox.Name = "Count_SelectBox";
            this.Count_SelectBox.Size = new System.Drawing.Size(121, 20);
            this.Count_SelectBox.TabIndex = 14;
            this.Count_SelectBox.SelectedIndexChanged += new System.EventHandler(this.Count_SelectBox_SelectedIndexChanged);
            // 
            // Type_SelectBox
            // 
            this.Type_SelectBox.FormattingEnabled = true;
            this.Type_SelectBox.Items.AddRange(new object[] {
            "단답형",
            "복수선택형",
            "서술형"});
            this.Type_SelectBox.Location = new System.Drawing.Point(1063, 126);
            this.Type_SelectBox.Name = "Type_SelectBox";
            this.Type_SelectBox.Size = new System.Drawing.Size(63, 20);
            this.Type_SelectBox.TabIndex = 13;
            this.Type_SelectBox.SelectedIndexChanged += new System.EventHandler(this.Type_SelectBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1000, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "문항 제목 작성";
            // 
            // Ttitle_SelectBox
            // 
            this.Ttitle_SelectBox.Location = new System.Drawing.Point(1002, 78);
            this.Ttitle_SelectBox.Name = "Ttitle_SelectBox";
            this.Ttitle_SelectBox.Size = new System.Drawing.Size(312, 21);
            this.Ttitle_SelectBox.TabIndex = 11;
            this.Ttitle_SelectBox.TextChanged += new System.EventHandler(this.Ttitle_SelectBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1000, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "문항 종류";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1202, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "문항 항목 갯수";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 932);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountList_SelectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number_SelectBox);
            this.Controls.Add(this.Content_SelcetBox);
            this.Controls.Add(this.Count_SelectBox);
            this.Controls.Add(this.Type_SelectBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ttitle_SelectBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Question_PushButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Question_PushButton;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox CountList_SelectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number_SelectBox;
        private System.Windows.Forms.TextBox Content_SelcetBox;
        private System.Windows.Forms.ComboBox Count_SelectBox;
        private System.Windows.Forms.ComboBox Type_SelectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ttitle_SelectBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

