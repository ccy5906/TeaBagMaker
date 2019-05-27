namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.TeaCombo = new System.Windows.Forms.ComboBox();
            this.but_add = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.butOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeaCombo
            // 
            this.TeaCombo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TeaCombo.FormattingEnabled = true;
            this.TeaCombo.Location = new System.Drawing.Point(12, 12);
            this.TeaCombo.Name = "TeaCombo";
            this.TeaCombo.Size = new System.Drawing.Size(178, 25);
            this.TeaCombo.TabIndex = 0;
            // 
            // but_add
            // 
            this.but_add.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.but_add.Location = new System.Drawing.Point(12, 54);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(178, 41);
            this.but_add.TabIndex = 1;
            this.but_add.Text = "담그기!";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.But_add_Click);
            // 
            // Countdown
            // 
            this.Countdown.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Countdown.Location = new System.Drawing.Point(12, 113);
            this.Countdown.Name = "Countdown";
            this.Countdown.ReadOnly = true;
            this.Countdown.Size = new System.Drawing.Size(178, 25);
            this.Countdown.TabIndex = 2;
            this.Countdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "2019.05.27 3517 최지연";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // butOK
            // 
            this.butOK.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.butOK.Location = new System.Drawing.Point(13, 158);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(177, 36);
            this.butOK.TabIndex = 4;
            this.butOK.Text = "확인";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 253);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.TeaCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "차선택";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TeaCombo;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.TextBox Countdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button butOK;
    }
}

