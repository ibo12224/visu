namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kitty01.JPG");
            this.imageList1.Images.SetKeyName(1, "kitty02.JPG");
            this.imageList1.Images.SetKeyName(2, "kitty03.JPG");
            this.imageList1.Images.SetKeyName(3, "kitty04.JPG");
            this.imageList1.Images.SetKeyName(4, "kitty05.JPG");
            this.imageList1.Images.SetKeyName(5, "kitty06.JPG");
            this.imageList1.Images.SetKeyName(6, "kitty07.JPG");
            this.imageList1.Images.SetKeyName(7, "kitty08.JPG");
            this.imageList1.Images.SetKeyName(8, "kitty09.JPG");
            this.imageList1.Images.SetKeyName(9, "kitty10.JPG");
            this.imageList1.Images.SetKeyName(10, "kitty11.JPG");
            this.imageList1.Images.SetKeyName(11, "kitty12.JPG");
            this.imageList1.Images.SetKeyName(12, "kitty13.JPG");
            this.imageList1.Images.SetKeyName(13, "kitty14.JPG");
            this.imageList1.Images.SetKeyName(14, "kitty15.JPG");
            this.imageList1.Images.SetKeyName(15, "kitty16.JPG");
            this.imageList1.Images.SetKeyName(16, "kitty17.JPG");
            this.imageList1.Images.SetKeyName(17, "kitty18.JPG");
            this.imageList1.Images.SetKeyName(18, "kitty19.JPG");
            this.imageList1.Images.SetKeyName(19, "kitty20.JPG");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 410);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        public ImageList imageList1;
    }
}