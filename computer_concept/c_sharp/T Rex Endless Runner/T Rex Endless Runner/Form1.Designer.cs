namespace T_Rex_Endless_Runner
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
            this.picFloor = new System.Windows.Forms.PictureBox();
            this.picTrex = new System.Windows.Forms.PictureBox();
            this.picCactus1 = new System.Windows.Forms.PictureBox();
            this.picCactus2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCactus2)).BeginInit();
            this.SuspendLayout();
            // 
            // picFloor
            // 
            this.picFloor.BackColor = System.Drawing.Color.Black;
            this.picFloor.Location = new System.Drawing.Point(-12, 452);
            this.picFloor.Name = "picFloor";
            this.picFloor.Size = new System.Drawing.Size(810, 50);
            this.picFloor.TabIndex = 0;
            this.picFloor.TabStop = false;
            // 
            // picTrex
            // 
            this.picTrex.Image = global::T_Rex_Endless_Runner.Properties.Resources.running;
            this.picTrex.Location = new System.Drawing.Point(35, 390);
            this.picTrex.Name = "picTrex";
            this.picTrex.Size = new System.Drawing.Size(44, 60);
            this.picTrex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrex.TabIndex = 1;
            this.picTrex.TabStop = false;
            // 
            // picCactus1
            // 
            this.picCactus1.Image = global::T_Rex_Endless_Runner.Properties.Resources.cactus1;
            this.picCactus1.Location = new System.Drawing.Point(446, 412);
            this.picCactus1.Name = "picCactus1";
            this.picCactus1.Size = new System.Drawing.Size(23, 40);
            this.picCactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCactus1.TabIndex = 2;
            this.picCactus1.TabStop = false;
            this.picCactus1.Tag = "cactus";
            // 
            // picCactus2
            // 
            this.picCactus2.Image = global::T_Rex_Endless_Runner.Properties.Resources.cactus2;
            this.picCactus2.Location = new System.Drawing.Point(730, 412);
            this.picCactus2.Name = "picCactus2";
            this.picCactus2.Size = new System.Drawing.Size(40, 40);
            this.picCactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCactus2.TabIndex = 3;
            this.picCactus2.TabStop = false;
            this.picCactus2.Tag = "cactus";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 24);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picCactus2);
            this.Controls.Add(this.picCactus1);
            this.Controls.Add(this.picTrex);
            this.Controls.Add(this.picFloor);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCactus2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFloor;
        private System.Windows.Forms.PictureBox picTrex;
        private System.Windows.Forms.PictureBox picCactus1;
        private System.Windows.Forms.PictureBox picCactus2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
    }
}

