namespace WFA24091301
{
    partial class FrmMain
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
            label1 = new Label();
            pbxRed = new PictureBox();
            pbxOrange = new PictureBox();
            pbxYellow = new PictureBox();
            pbxGreen = new PictureBox();
            pbxPurble = new PictureBox();
            pbxViolet = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPurble).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxViolet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(427, 107);
            label1.TabIndex = 0;
            label1.Text = "Kattints valamelyik színes téglalapra!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxRed
            // 
            pbxRed.BackColor = Color.Crimson;
            pbxRed.Location = new Point(12, 119);
            pbxRed.Name = "pbxRed";
            pbxRed.Size = new Size(427, 45);
            pbxRed.TabIndex = 1;
            pbxRed.TabStop = false;
            // 
            // pbxOrange
            // 
            pbxOrange.BackColor = Color.Orange;
            pbxOrange.Location = new Point(12, 202);
            pbxOrange.Name = "pbxOrange";
            pbxOrange.Size = new Size(427, 45);
            pbxOrange.TabIndex = 1;
            pbxOrange.TabStop = false;
            // 
            // pbxYellow
            // 
            pbxYellow.BackColor = Color.Yellow;
            pbxYellow.Location = new Point(12, 285);
            pbxYellow.Name = "pbxYellow";
            pbxYellow.Size = new Size(427, 45);
            pbxYellow.TabIndex = 1;
            pbxYellow.TabStop = false;
            // 
            // pbxGreen
            // 
            pbxGreen.BackColor = Color.LawnGreen;
            pbxGreen.Location = new Point(12, 368);
            pbxGreen.Name = "pbxGreen";
            pbxGreen.Size = new Size(427, 45);
            pbxGreen.TabIndex = 1;
            pbxGreen.TabStop = false;
            // 
            // pbxPurble
            // 
            pbxPurble.BackColor = Color.DodgerBlue;
            pbxPurble.Location = new Point(12, 451);
            pbxPurble.Name = "pbxPurble";
            pbxPurble.Size = new Size(427, 45);
            pbxPurble.TabIndex = 1;
            pbxPurble.TabStop = false;
            // 
            // pbxViolet
            // 
            pbxViolet.BackColor = Color.DarkViolet;
            pbxViolet.Location = new Point(12, 534);
            pbxViolet.Name = "pbxViolet";
            pbxViolet.Size = new Size(427, 45);
            pbxViolet.TabIndex = 1;
            pbxViolet.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 608);
            Controls.Add(pbxViolet);
            Controls.Add(pbxPurble);
            Controls.Add(pbxGreen);
            Controls.Add(pbxYellow);
            Controls.Add(pbxOrange);
            Controls.Add(pbxRed);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "Színező";
            ((System.ComponentModel.ISupportInitialize)pbxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPurble).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxViolet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pbxRed;
        private PictureBox pbxOrange;
        private PictureBox pbxYellow;
        private PictureBox pbxGreen;
        private PictureBox pbxPurble;
        private PictureBox pbxViolet;
    }
}
