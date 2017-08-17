/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - Aug 17, 2017
 * Description - Pick Higest Card
 * Version: 0.1
 */
namespace COMP123_S2017_3006228931
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblwelcome2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Location = new System.Drawing.Point(259, 160);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(61, 13);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "300622893";
            // 
            // lblwelcome2
            // 
            this.lblwelcome2.AutoSize = true;
            this.lblwelcome2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblwelcome2.Location = new System.Drawing.Point(247, 160);
            this.lblwelcome2.Name = "lblwelcome2";
            this.lblwelcome2.Size = new System.Drawing.Size(49, 13);
            this.lblwelcome2.TabIndex = 2;
            this.lblwelcome2.Text = "welcome";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.lblwelcome2);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblwelcome2;
    }
}