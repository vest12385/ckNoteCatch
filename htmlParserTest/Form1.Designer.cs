namespace htmlParserTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.startPage = new System.Windows.Forms.TextBox();
            this.howPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(300, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "從";
            // 
            // startPage
            // 
            this.startPage.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startPage.Location = new System.Drawing.Point(295, 73);
            this.startPage.Margin = new System.Windows.Forms.Padding(2);
            this.startPage.Name = "startPage";
            this.startPage.Size = new System.Drawing.Size(38, 30);
            this.startPage.TabIndex = 11;
            this.startPage.Text = "1";
            this.startPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // howPage
            // 
            this.howPage.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.howPage.Location = new System.Drawing.Point(252, 43);
            this.howPage.Margin = new System.Windows.Forms.Padding(2);
            this.howPage.Name = "howPage";
            this.howPage.Size = new System.Drawing.Size(38, 30);
            this.howPage.TabIndex = 12;
            this.howPage.Text = "1";
            this.howPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(300, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "頁\r\n開\r\n始";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(256, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 114);
            this.label1.TabIndex = 10;
            this.label1.Text = "頁\r\n為\r\n一\r\n個\r\n檔\r\n案";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(11, 43);
            this.state.Margin = new System.Windows.Forms.Padding(2);
            this.state.Multiline = true;
            this.state.Name = "state";
            this.state.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.state.Size = new System.Drawing.Size(242, 238);
            this.state.TabIndex = 8;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(256, 11);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(69, 28);
            this.start.TabIndex = 7;
            this.start.Text = "Catch";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // web
            // 
            this.web.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.web.Location = new System.Drawing.Point(11, 11);
            this.web.Margin = new System.Windows.Forms.Padding(2);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(242, 30);
            this.web.TabIndex = 6;
            this.web.Text = "1482470";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startPage);
            this.Controls.Add(this.howPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.start);
            this.Controls.Add(this.web);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startPage;
        private System.Windows.Forms.TextBox howPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox web;
    }
}

