
namespace _2021_10_13_tron_game_GE
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
            this.components = new System.ComponentModel.Container();
            this.alapPANEL = new System.Windows.Forms.Panel();
            this.oraTIMER = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timePANEL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // alapPANEL
            // 
            this.alapPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.alapPANEL.Location = new System.Drawing.Point(12, 12);
            this.alapPANEL.Name = "alapPANEL";
            this.alapPANEL.Size = new System.Drawing.Size(624, 624);
            this.alapPANEL.TabIndex = 0;
            // 
            // oraTIMER
            // 
            this.oraTIMER.Interval = 1000;
            this.oraTIMER.Tick += new System.EventHandler(this.oraTIMER_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(703, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timePANEL
            // 
            this.timePANEL.BackColor = System.Drawing.Color.Gray;
            this.timePANEL.Location = new System.Drawing.Point(642, 12);
            this.timePANEL.Name = "timePANEL";
            this.timePANEL.Size = new System.Drawing.Size(320, 100);
            this.timePANEL.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(970, 647);
            this.Controls.Add(this.timePANEL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alapPANEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel alapPANEL;
        private System.Windows.Forms.Timer oraTIMER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel timePANEL;
    }
}

