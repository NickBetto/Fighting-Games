namespace Fighting_Games
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.gameButton1 = new System.Windows.Forms.Button();
            this.gameButton2 = new System.Windows.Forms.Button();
            this.gameButton3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.titleLabel.Location = new System.Drawing.Point(121, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(511, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CHOOSE YOUR GAME";
            // 
            // gameButton1
            // 
            this.gameButton1.BackColor = System.Drawing.Color.Transparent;
            this.gameButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gameButton1.FlatAppearance.BorderSize = 5;
            this.gameButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gameButton1.Location = new System.Drawing.Point(91, 306);
            this.gameButton1.Name = "gameButton1";
            this.gameButton1.Size = new System.Drawing.Size(146, 137);
            this.gameButton1.TabIndex = 1;
            this.gameButton1.Text = "1v1";
            this.gameButton1.UseVisualStyleBackColor = false;
            this.gameButton1.Click += new System.EventHandler(this.gameButton1_Click);
            // 
            // gameButton2
            // 
            this.gameButton2.BackColor = System.Drawing.Color.Transparent;
            this.gameButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gameButton2.FlatAppearance.BorderSize = 5;
            this.gameButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gameButton2.Location = new System.Drawing.Point(290, 310);
            this.gameButton2.Name = "gameButton2";
            this.gameButton2.Size = new System.Drawing.Size(146, 137);
            this.gameButton2.TabIndex = 2;
            this.gameButton2.Text = "Waves";
            this.gameButton2.UseVisualStyleBackColor = false;
            this.gameButton2.Click += new System.EventHandler(this.gameButton2_Click);
            // 
            // gameButton3
            // 
            this.gameButton3.BackColor = System.Drawing.Color.Transparent;
            this.gameButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gameButton3.FlatAppearance.BorderSize = 5;
            this.gameButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gameButton3.Location = new System.Drawing.Point(474, 310);
            this.gameButton3.Name = "gameButton3";
            this.gameButton3.Size = new System.Drawing.Size(146, 137);
            this.gameButton3.TabIndex = 3;
            this.gameButton3.Text = "Endless";
            this.gameButton3.UseVisualStyleBackColor = false;
            this.gameButton3.Click += new System.EventHandler(this.gameButton3_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 5;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitButton.Location = new System.Drawing.Point(660, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 91);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Fighting_Games.Properties.Resources.Dojo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameButton3);
            this.Controls.Add(this.gameButton2);
            this.Controls.Add(this.gameButton1);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(796, 597);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button gameButton1;
        private System.Windows.Forms.Button gameButton2;
        private System.Windows.Forms.Button gameButton3;
        private System.Windows.Forms.Button exitButton;
    }
}
