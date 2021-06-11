namespace zombieShooter
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmrZombie = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblKill = new System.Windows.Forms.Label();
            this.lblBulletNum = new System.Windows.Forms.Label();
            this.picCastle = new System.Windows.Forms.PictureBox();
            this.picZombie = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrAmmo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "血";
            // 
            // tmrZombie
            // 
            this.tmrZombie.Enabled = true;
            this.tmrZombie.Interval = 2000;
            this.tmrZombie.Tick += new System.EventHandler(this.tmrZombie_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 5);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 28);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 50;
            // 
            // lblKill
            // 
            this.lblKill.AutoSize = true;
            this.lblKill.Location = new System.Drawing.Point(15, 51);
            this.lblKill.Name = "lblKill";
            this.lblKill.Size = new System.Drawing.Size(50, 18);
            this.lblKill.TabIndex = 5;
            this.lblKill.Text = "label1";
            // 
            // lblBulletNum
            // 
            this.lblBulletNum.AutoSize = true;
            this.lblBulletNum.Location = new System.Drawing.Point(15, 85);
            this.lblBulletNum.Name = "lblBulletNum";
            this.lblBulletNum.Size = new System.Drawing.Size(50, 18);
            this.lblBulletNum.TabIndex = 6;
            this.lblBulletNum.Text = "label2";
            // 
            // picCastle
            // 
            this.picCastle.Image = global::zombieShooter.Properties.Resources.castle;
            this.picCastle.Location = new System.Drawing.Point(925, 282);
            this.picCastle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCastle.Name = "picCastle";
            this.picCastle.Size = new System.Drawing.Size(111, 115);
            this.picCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCastle.TabIndex = 2;
            this.picCastle.TabStop = false;
            // 
            // picZombie
            // 
            this.picZombie.Image = global::zombieShooter.Properties.Resources.zleft;
            this.picZombie.Location = new System.Drawing.Point(536, 248);
            this.picZombie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picZombie.Name = "picZombie";
            this.picZombie.Size = new System.Drawing.Size(56, 60);
            this.picZombie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZombie.TabIndex = 1;
            this.picZombie.TabStop = false;
            this.picZombie.Tag = "zombie";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::zombieShooter.Properties.Resources.right;
            this.picPlayer.Location = new System.Drawing.Point(138, 248);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(56, 60);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrAmmo
            // 
            this.tmrAmmo.Enabled = true;
            this.tmrAmmo.Interval = 5000;
            this.tmrAmmo.Tick += new System.EventHandler(this.tmrAmmo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 846);
            this.Controls.Add(this.lblBulletNum);
            this.Controls.Add(this.lblKill);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCastle);
            this.Controls.Add(this.picZombie);
            this.Controls.Add(this.picPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZombie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picZombie;
        private System.Windows.Forms.PictureBox picCastle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrZombie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblKill;
        private System.Windows.Forms.Label lblBulletNum;
        private System.Windows.Forms.Timer tmrAmmo;
    }
}

