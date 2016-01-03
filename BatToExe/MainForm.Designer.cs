namespace SoftwareByDefault.OpenSource.BatToExe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInputBatch = new System.Windows.Forms.Label();
            this.txtInputBatch = new System.Windows.Forms.TextBox();
            this.txtOutputExe = new System.Windows.Forms.TextBox();
            this.lblOutputExe = new System.Windows.Forms.Label();
            this.btnOpenBatch = new System.Windows.Forms.Button();
            this.btnSaveExecutable = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkShowOutput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblInputBatch
            // 
            this.lblInputBatch.AutoSize = true;
            this.lblInputBatch.Location = new System.Drawing.Point(13, 13);
            this.lblInputBatch.Name = "lblInputBatch";
            this.lblInputBatch.Size = new System.Drawing.Size(84, 13);
            this.lblInputBatch.TabIndex = 0;
            this.lblInputBatch.Text = "Input Batch File:";
            // 
            // txtInputBatch
            // 
            this.txtInputBatch.Location = new System.Drawing.Point(112, 10);
            this.txtInputBatch.Name = "txtInputBatch";
            this.txtInputBatch.Size = new System.Drawing.Size(488, 20);
            this.txtInputBatch.TabIndex = 1;
            // 
            // txtOutputExe
            // 
            this.txtOutputExe.Location = new System.Drawing.Point(112, 39);
            this.txtOutputExe.Name = "txtOutputExe";
            this.txtOutputExe.Size = new System.Drawing.Size(488, 20);
            this.txtOutputExe.TabIndex = 3;
            // 
            // lblOutputExe
            // 
            this.lblOutputExe.AutoSize = true;
            this.lblOutputExe.Location = new System.Drawing.Point(13, 42);
            this.lblOutputExe.Name = "lblOutputExe";
            this.lblOutputExe.Size = new System.Drawing.Size(82, 13);
            this.lblOutputExe.TabIndex = 2;
            this.lblOutputExe.Text = "Output Exe File:";
            // 
            // btnOpenBatch
            // 
            this.btnOpenBatch.BackgroundImage = global::SoftwareByDefault.OpenSource.BatToExe.Properties.Resources.GreenPlus_16x16_72;
            this.btnOpenBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBatch.Location = new System.Drawing.Point(606, 7);
            this.btnOpenBatch.Name = "btnOpenBatch";
            this.btnOpenBatch.Size = new System.Drawing.Size(25, 25);
            this.btnOpenBatch.TabIndex = 4;
            this.btnOpenBatch.UseVisualStyleBackColor = true;
            this.btnOpenBatch.Click += new System.EventHandler(this.btnOpenBatch_Click);
            // 
            // btnSaveExecutable
            // 
            this.btnSaveExecutable.BackgroundImage = global::SoftwareByDefault.OpenSource.BatToExe.Properties.Resources.GreenPlus_16x16_72;
            this.btnSaveExecutable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveExecutable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExecutable.Location = new System.Drawing.Point(606, 36);
            this.btnSaveExecutable.Name = "btnSaveExecutable";
            this.btnSaveExecutable.Size = new System.Drawing.Size(25, 25);
            this.btnSaveExecutable.TabIndex = 5;
            this.btnSaveExecutable.UseVisualStyleBackColor = true;
            this.btnSaveExecutable.Click += new System.EventHandler(this.btnSaveExecutable_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerate.Image = global::SoftwareByDefault.OpenSource.BatToExe.Properties.Resources.GreenCheck_16x16_72;
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.Location = new System.Drawing.Point(556, 79);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 32);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SoftwareByDefault.OpenSource.BatToExe.Properties.Resources.RedError_16x16_72;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(16, 79);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkShowOutput
            // 
            this.chkShowOutput.AutoSize = true;
            this.chkShowOutput.Checked = true;
            this.chkShowOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowOutput.Location = new System.Drawing.Point(112, 65);
            this.chkShowOutput.Name = "chkShowOutput";
            this.chkShowOutput.Size = new System.Drawing.Size(133, 17);
            this.chkShowOutput.TabIndex = 8;
            this.chkShowOutput.Text = "Show Batch file output";
            this.chkShowOutput.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 119);
            this.Controls.Add(this.chkShowOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSaveExecutable);
            this.Controls.Add(this.btnOpenBatch);
            this.Controls.Add(this.txtOutputExe);
            this.Controls.Add(this.lblOutputExe);
            this.Controls.Add(this.txtInputBatch);
            this.Controls.Add(this.lblInputBatch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatToExe :: Version 0.5.5.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputBatch;
        private System.Windows.Forms.TextBox txtInputBatch;
        private System.Windows.Forms.TextBox txtOutputExe;
        private System.Windows.Forms.Label lblOutputExe;
        private System.Windows.Forms.Button btnOpenBatch;
        private System.Windows.Forms.Button btnSaveExecutable;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkShowOutput;
    }
}

