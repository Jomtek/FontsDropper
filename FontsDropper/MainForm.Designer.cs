
namespace FontsDropper
{
    partial class MainForm
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
            this.processBTN = new System.Windows.Forms.Button();
            this.linkTB = new System.Windows.Forms.TextBox();
            this.resultWB = new System.Windows.Forms.WebBrowser();
            this.sizeNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // processBTN
            // 
            this.processBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBTN.Location = new System.Drawing.Point(386, 12);
            this.processBTN.Name = "processBTN";
            this.processBTN.Size = new System.Drawing.Size(73, 34);
            this.processBTN.TabIndex = 0;
            this.processBTN.Text = "Grab";
            this.processBTN.UseVisualStyleBackColor = true;
            this.processBTN.Click += new System.EventHandler(this.ProcessBTN_Click);
            // 
            // linkTB
            // 
            this.linkTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTB.Location = new System.Drawing.Point(13, 15);
            this.linkTB.Name = "linkTB";
            this.linkTB.Size = new System.Drawing.Size(294, 29);
            this.linkTB.TabIndex = 1;
            // 
            // resultWB
            // 
            this.resultWB.Location = new System.Drawing.Point(13, 50);
            this.resultWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.resultWB.Name = "resultWB";
            this.resultWB.ScrollBarsEnabled = false;
            this.resultWB.Size = new System.Drawing.Size(446, 188);
            this.resultWB.TabIndex = 4;
            this.resultWB.WebBrowserShortcutsEnabled = false;
            // 
            // sizeNUD
            // 
            this.sizeNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeNUD.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeNUD.Location = new System.Drawing.Point(314, 15);
            this.sizeNUD.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.sizeNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeNUD.Name = "sizeNUD";
            this.sizeNUD.Size = new System.Drawing.Size(66, 29);
            this.sizeNUD.TabIndex = 5;
            this.sizeNUD.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 252);
            this.Controls.Add(this.sizeNUD);
            this.Controls.Add(this.resultWB);
            this.Controls.Add(this.linkTB);
            this.Controls.Add(this.processBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "FontsDropper by Jomtek (duotone not supported!)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sizeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processBTN;
        private System.Windows.Forms.TextBox linkTB;
        private System.Windows.Forms.WebBrowser resultWB;
        private System.Windows.Forms.NumericUpDown sizeNUD;
    }
}

