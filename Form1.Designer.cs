namespace Class_Dog
{
    partial class Form1
    {
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(260, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Woof";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxDog
            // 
            this.pictureBoxDog.BackgroundImage = global::Dog.Properties.Resources.No_Dogs;
            this.pictureBoxDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDog.Location = new System.Drawing.Point(210, 12);
            this.pictureBoxDog.MaximumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxDog.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxDog.Name = "pictureBoxDog";
            this.pictureBoxDog.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDog.TabIndex = 0;
            this.pictureBoxDog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.pictureBoxDog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Class_Dog";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private PictureBox pictureBoxDog;
    }
}