namespace BalonPatlatmaOyunu
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
            components = new System.ComponentModel.Container();
            BalonOlusturucu = new System.Windows.Forms.Timer(components);
            BalonDüsürücü = new System.Windows.Forms.Timer(components);
            lbl_skor = new Label();
            SuspendLayout();
            // 
            // BalonOlusturucu
            // 
            BalonOlusturucu.Interval = 700;
            BalonOlusturucu.Tick += BalonOlusturucu_Tick;
            // 
            // BalonDüsürücü
            // 
            BalonDüsürücü.Interval = 60;
            BalonDüsürücü.Tick += BalonDüsürücü_Tick;
            // 
            // lbl_skor
            // 
            lbl_skor.AutoSize = true;
            lbl_skor.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_skor.Location = new Point(27, 515);
            lbl_skor.Name = "lbl_skor";
            lbl_skor.Size = new Size(22, 23);
            lbl_skor.TabIndex = 0;
            lbl_skor.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lbl_skor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer BalonOlusturucu;
        private System.Windows.Forms.Timer BalonDüsürücü;
        private Label lbl_skor;
    }
}
