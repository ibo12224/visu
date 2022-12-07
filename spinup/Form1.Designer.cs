namespace spinup {
    partial class frmAnimaion {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimaion));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.picChoice0 = new System.Windows.Forms.PictureBox();
            this.timAnimation = new System.Windows.Forms.Timer(this.components);
            this.picChoice1 = new System.Windows.Forms.PictureBox();
            this.picChoice5 = new System.Windows.Forms.PictureBox();
            this.picChoice3 = new System.Windows.Forms.PictureBox();
            this.picChoice4 = new System.Windows.Forms.PictureBox();
            this.picChoice2 = new System.Windows.Forms.PictureBox();
            this.picChoice6 = new System.Windows.Forms.PictureBox();
            this.picChoice7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice7)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Image = ((System.Drawing.Image)(resources.GetObject("picDisplay.Image")));
            this.picDisplay.Location = new System.Drawing.Point(95, 39);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(267, 159);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(144, 228);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(180, 50);
            this.btnTimer.TabIndex = 1;
            this.btnTimer.Text = "button1";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // picChoice0
            // 
            this.picChoice0.Image = ((System.Drawing.Image)(resources.GetObject("picChoice0.Image")));
            this.picChoice0.Location = new System.Drawing.Point(12, 334);
            this.picChoice0.Name = "picChoice0";
            this.picChoice0.Size = new System.Drawing.Size(67, 83);
            this.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice0.TabIndex = 2;
            this.picChoice0.TabStop = false;
            this.picChoice0.Visible = false;
            // 
            // timAnimation
            // 
            this.timAnimation.Tick += new System.EventHandler(this.timAnimation_Tick);
            // 
            // picChoice1
            // 
            this.picChoice1.Image = ((System.Drawing.Image)(resources.GetObject("picChoice1.Image")));
            this.picChoice1.Location = new System.Drawing.Point(95, 334);
            this.picChoice1.Name = "picChoice1";
            this.picChoice1.Size = new System.Drawing.Size(67, 83);
            this.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice1.TabIndex = 3;
            this.picChoice1.TabStop = false;
            this.picChoice1.Visible = false;
            // 
            // picChoice5
            // 
            this.picChoice5.Image = ((System.Drawing.Image)(resources.GetObject("picChoice5.Image")));
            this.picChoice5.Location = new System.Drawing.Point(439, 334);
            this.picChoice5.Name = "picChoice5";
            this.picChoice5.Size = new System.Drawing.Size(67, 83);
            this.picChoice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice5.TabIndex = 4;
            this.picChoice5.TabStop = false;
            this.picChoice5.Visible = false;
            // 
            // picChoice3
            // 
            this.picChoice3.Image = ((System.Drawing.Image)(resources.GetObject("picChoice3.Image")));
            this.picChoice3.Location = new System.Drawing.Point(270, 334);
            this.picChoice3.Name = "picChoice3";
            this.picChoice3.Size = new System.Drawing.Size(67, 83);
            this.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice3.TabIndex = 5;
            this.picChoice3.TabStop = false;
            this.picChoice3.Visible = false;
            // 
            // picChoice4
            // 
            this.picChoice4.Image = ((System.Drawing.Image)(resources.GetObject("picChoice4.Image")));
            this.picChoice4.Location = new System.Drawing.Point(354, 334);
            this.picChoice4.Name = "picChoice4";
            this.picChoice4.Size = new System.Drawing.Size(67, 83);
            this.picChoice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice4.TabIndex = 6;
            this.picChoice4.TabStop = false;
            this.picChoice4.Visible = false;
            // 
            // picChoice2
            // 
            this.picChoice2.Image = ((System.Drawing.Image)(resources.GetObject("picChoice2.Image")));
            this.picChoice2.Location = new System.Drawing.Point(187, 334);
            this.picChoice2.Name = "picChoice2";
            this.picChoice2.Size = new System.Drawing.Size(67, 83);
            this.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice2.TabIndex = 7;
            this.picChoice2.TabStop = false;
            this.picChoice2.Visible = false;
            // 
            // picChoice6
            // 
            this.picChoice6.Image = ((System.Drawing.Image)(resources.GetObject("picChoice6.Image")));
            this.picChoice6.Location = new System.Drawing.Point(523, 334);
            this.picChoice6.Name = "picChoice6";
            this.picChoice6.Size = new System.Drawing.Size(67, 83);
            this.picChoice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice6.TabIndex = 8;
            this.picChoice6.TabStop = false;
            this.picChoice6.Visible = false;
            // 
            // picChoice7
            // 
            this.picChoice7.Image = ((System.Drawing.Image)(resources.GetObject("picChoice7.Image")));
            this.picChoice7.Location = new System.Drawing.Point(613, 334);
            this.picChoice7.Name = "picChoice7";
            this.picChoice7.Size = new System.Drawing.Size(67, 83);
            this.picChoice7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoice7.TabIndex = 9;
            this.picChoice7.TabStop = false;
            this.picChoice7.Visible = false;
            // 
            // frmAnimaion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picChoice7);
            this.Controls.Add(this.picChoice6);
            this.Controls.Add(this.picChoice2);
            this.Controls.Add(this.picChoice4);
            this.Controls.Add(this.picChoice3);
            this.Controls.Add(this.picChoice5);
            this.Controls.Add(this.picChoice1);
            this.Controls.Add(this.picChoice0);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnimaion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoice7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.PictureBox picChoice0;
        private System.Windows.Forms.Timer timAnimation;
        private System.Windows.Forms.PictureBox picChoice1;
        private System.Windows.Forms.PictureBox picChoice5;
        private System.Windows.Forms.PictureBox picChoice3;
        private System.Windows.Forms.PictureBox picChoice4;
        private System.Windows.Forms.PictureBox picChoice2;
        private System.Windows.Forms.PictureBox picChoice6;
        private System.Windows.Forms.PictureBox picChoice7;
    }
}

