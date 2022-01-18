
namespace monthkalendar
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
            this.moncalKalendar = new System.Windows.Forms.MonthCalendar();
            this.btnTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moncalKalendar
            // 
            this.moncalKalendar.Location = new System.Drawing.Point(40, 30);
            this.moncalKalendar.MaxSelectionCount = 30;
            this.moncalKalendar.Name = "moncalKalendar";
            this.moncalKalendar.ShowWeekNumbers = true;
            this.moncalKalendar.TabIndex = 0;
            this.moncalKalendar.TabStop = false;
            // 
            // btnTermin
            // 
            this.btnTermin.Location = new System.Drawing.Point(110, 228);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(75, 23);
            this.btnTermin.TabIndex = 1;
            this.btnTermin.Text = "Rezerviraj";
            this.btnTermin.UseVisualStyleBackColor = true;
            this.btnTermin.Click += new System.EventHandler(this.btnTermin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 276);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.moncalKalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar moncalKalendar;
        private System.Windows.Forms.Button btnTermin;
    }
}

