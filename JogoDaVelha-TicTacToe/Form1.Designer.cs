namespace JogoDaVelha_TicTacToe
{
    partial class Form1
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
            this.gameLog = new System.Windows.Forms.TextBox();
            this.button01 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button04 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameTitle = new System.Windows.Forms.TextBox();
            this.gameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameLog
            // 
            this.gameLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLog.Location = new System.Drawing.Point(15, 70);
            this.gameLog.Multiline = true;
            this.gameLog.Name = "gameLog";
            this.gameLog.ReadOnly = true;
            this.gameLog.Size = new System.Drawing.Size(300, 40);
            this.gameLog.TabIndex = 0;
            this.gameLog.Text = "--------------";
            this.gameLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button01
            // 
            this.button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button01.Location = new System.Drawing.Point(87, 16);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(70, 61);
            this.button01.TabIndex = 1;
            this.button01.Tag = "gridSelectable";
            this.button01.Text = "-";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(80, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(9, 195);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(156, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(9, 195);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(11, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 11);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(11, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(222, 11);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // button04
            // 
            this.button04.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button04.Location = new System.Drawing.Point(87, 83);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(70, 61);
            this.button04.TabIndex = 1;
            this.button04.Tag = "gridSelectable";
            this.button04.Text = "-";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button07
            // 
            this.button07.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button07.Location = new System.Drawing.Point(87, 150);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(70, 61);
            this.button07.TabIndex = 1;
            this.button07.Tag = "gridSelectable";
            this.button07.Text = "-";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button05
            // 
            this.button05.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button05.Location = new System.Drawing.Point(163, 83);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(70, 61);
            this.button05.TabIndex = 1;
            this.button05.Tag = "gridSelectable";
            this.button05.Text = "-";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button02
            // 
            this.button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button02.Location = new System.Drawing.Point(163, 16);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(70, 61);
            this.button02.TabIndex = 1;
            this.button02.Tag = "gridSelectable";
            this.button02.Text = "-";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button00
            // 
            this.button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.Location = new System.Drawing.Point(11, 16);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(70, 61);
            this.button00.TabIndex = 1;
            this.button00.Tag = "gridSelectable";
            this.button00.Text = "-";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button03
            // 
            this.button03.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button03.Location = new System.Drawing.Point(11, 83);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(70, 61);
            this.button03.TabIndex = 1;
            this.button03.Tag = "gridSelectable";
            this.button03.Text = "-";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button06
            // 
            this.button06.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button06.Location = new System.Drawing.Point(11, 150);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(70, 61);
            this.button06.TabIndex = 1;
            this.button06.Tag = "gridSelectable";
            this.button06.Text = "-";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // button08
            // 
            this.button08.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button08.Location = new System.Drawing.Point(163, 150);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(70, 61);
            this.button08.TabIndex = 1;
            this.button08.Tag = "gridSelectable";
            this.button08.Text = "-";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.GridButton_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button07);
            this.groupBox1.Controls.Add(this.button08);
            this.groupBox1.Controls.Add(this.button06);
            this.groupBox1.Controls.Add(this.button03);
            this.groupBox1.Controls.Add(this.button00);
            this.groupBox1.Controls.Add(this.button02);
            this.groupBox1.Controls.Add(this.button05);
            this.groupBox1.Controls.Add(this.button04);
            this.groupBox1.Controls.Add(this.button01);
            this.groupBox1.Location = new System.Drawing.Point(42, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // gameTitle
            // 
            this.gameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(11, 5);
            this.gameTitle.Multiline = true;
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.ReadOnly = true;
            this.gameTitle.Size = new System.Drawing.Size(313, 44);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Jogo da Velha";
            this.gameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameButton
            // 
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.Location = new System.Drawing.Point(53, 375);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(222, 62);
            this.gameButton.TabIndex = 4;
            this.gameButton.Text = "Iniciar o jogo";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.gameLog);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameLog;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gameTitle;
        private System.Windows.Forms.Button gameButton;
    }
}

