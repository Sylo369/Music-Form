namespace Musical_Form
{
    partial class mainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metalButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.hiphopButton = new System.Windows.Forms.Button();
            this.jazzButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metalButton);
            this.groupBox1.Controls.Add(this.popButton);
            this.groupBox1.Controls.Add(this.hiphopButton);
            this.groupBox1.Controls.Add(this.jazzButton);
            this.groupBox1.Controls.Add(this.rockButton);
            this.groupBox1.Location = new System.Drawing.Point(34, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genres";
            // 
            // metalButton
            // 
            this.metalButton.Location = new System.Drawing.Point(590, 21);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(140, 44);
            this.metalButton.TabIndex = 4;
            this.metalButton.Text = "Metal";
            this.metalButton.UseVisualStyleBackColor = true;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(444, 21);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(140, 44);
            this.popButton.TabIndex = 3;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // hiphopButton
            // 
            this.hiphopButton.Location = new System.Drawing.Point(298, 21);
            this.hiphopButton.Name = "hiphopButton";
            this.hiphopButton.Size = new System.Drawing.Size(140, 44);
            this.hiphopButton.TabIndex = 2;
            this.hiphopButton.Text = "Hip-Hip";
            this.hiphopButton.UseVisualStyleBackColor = true;
            this.hiphopButton.Click += new System.EventHandler(this.hiphopButton_Click);
            // 
            // jazzButton
            // 
            this.jazzButton.Location = new System.Drawing.Point(152, 21);
            this.jazzButton.Name = "jazzButton";
            this.jazzButton.Size = new System.Drawing.Size(140, 44);
            this.jazzButton.TabIndex = 1;
            this.jazzButton.Text = "Jazz";
            this.jazzButton.UseVisualStyleBackColor = true;
            this.jazzButton.Click += new System.EventHandler(this.jazzButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(6, 21);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(140, 44);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crazy Music Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainPage";
            this.Text = "Genres";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button hiphopButton;
        private System.Windows.Forms.Button jazzButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

