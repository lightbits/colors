namespace Colors
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
            this.fChooseColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fColorPanel = new System.Windows.Forms.Panel();
            this.fRedText = new System.Windows.Forms.TextBox();
            this.fGreenText = new System.Windows.Forms.TextBox();
            this.fBlueText = new System.Windows.Forms.TextBox();
            this.fHexText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fPictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.fCheckBoxCopyHex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fPictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // fChooseColorButton
            // 
            this.fChooseColorButton.Location = new System.Drawing.Point(12, 118);
            this.fChooseColorButton.Name = "fChooseColorButton";
            this.fChooseColorButton.Size = new System.Drawing.Size(103, 23);
            this.fChooseColorButton.TabIndex = 4;
            this.fChooseColorButton.Text = "Pick";
            this.fChooseColorButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "B:";
            // 
            // fColorPanel
            // 
            this.fColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fColorPanel.Location = new System.Drawing.Point(55, 52);
            this.fColorPanel.Name = "fColorPanel";
            this.fColorPanel.Size = new System.Drawing.Size(60, 60);
            this.fColorPanel.TabIndex = 15;
            // 
            // fRedText
            // 
            this.fRedText.Location = new System.Drawing.Point(155, 12);
            this.fRedText.MaxLength = 3;
            this.fRedText.Name = "fRedText";
            this.fRedText.Size = new System.Drawing.Size(40, 20);
            this.fRedText.TabIndex = 0;
            this.fRedText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTextboxClick);
            this.fRedText.TextChanged += new System.EventHandler(this.OnRGBTextChanged);
            this.fRedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnRGBTextKeyPress);
            // 
            // fGreenText
            // 
            this.fGreenText.Location = new System.Drawing.Point(155, 38);
            this.fGreenText.MaxLength = 3;
            this.fGreenText.Name = "fGreenText";
            this.fGreenText.Size = new System.Drawing.Size(40, 20);
            this.fGreenText.TabIndex = 1;
            this.fGreenText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTextboxClick);
            this.fGreenText.TextChanged += new System.EventHandler(this.OnRGBTextChanged);
            this.fGreenText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnRGBTextKeyPress);
            // 
            // fBlueText
            // 
            this.fBlueText.Location = new System.Drawing.Point(155, 64);
            this.fBlueText.MaxLength = 3;
            this.fBlueText.Name = "fBlueText";
            this.fBlueText.Size = new System.Drawing.Size(40, 20);
            this.fBlueText.TabIndex = 2;
            this.fBlueText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTextboxClick);
            this.fBlueText.TextChanged += new System.EventHandler(this.OnRGBTextChanged);
            this.fBlueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnRGBTextKeyPress);
            // 
            // fHexText
            // 
            this.fHexText.Location = new System.Drawing.Point(135, 90);
            this.fHexText.MaxLength = 6;
            this.fHexText.Name = "fHexText";
            this.fHexText.Size = new System.Drawing.Size(60, 20);
            this.fHexText.TabIndex = 3;
            this.fHexText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTextboxClick);
            this.fHexText.TextChanged += new System.EventHandler(this.OnHexTextChanged);
            this.fHexText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnHexTextKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "#";
            // 
            // fPictureBoxPreview
            // 
            this.fPictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fPictureBoxPreview.Location = new System.Drawing.Point(12, 12);
            this.fPictureBoxPreview.Name = "fPictureBoxPreview";
            this.fPictureBoxPreview.Size = new System.Drawing.Size(80, 80);
            this.fPictureBoxPreview.TabIndex = 0;
            this.fPictureBoxPreview.TabStop = false;
            // 
            // fCheckBoxCopyHex
            // 
            this.fCheckBoxCopyHex.AutoSize = true;
            this.fCheckBoxCopyHex.Location = new System.Drawing.Point(121, 122);
            this.fCheckBoxCopyHex.Name = "fCheckBoxCopyHex";
            this.fCheckBoxCopyHex.Size = new System.Drawing.Size(70, 17);
            this.fCheckBoxCopyHex.TabIndex = 20;
            this.fCheckBoxCopyHex.Text = "Copy hex";
            this.fCheckBoxCopyHex.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 147);
            this.Controls.Add(this.fCheckBoxCopyHex);
            this.Controls.Add(this.fPictureBoxPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fHexText);
            this.Controls.Add(this.fBlueText);
            this.Controls.Add(this.fGreenText);
            this.Controls.Add(this.fRedText);
            this.Controls.Add(this.fColorPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fChooseColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.fPictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fChooseColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel fColorPanel;
        private System.Windows.Forms.TextBox fRedText;
        private System.Windows.Forms.TextBox fGreenText;
        private System.Windows.Forms.TextBox fBlueText;
        private System.Windows.Forms.TextBox fHexText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fPictureBoxPreview;
        private System.Windows.Forms.CheckBox fCheckBoxCopyHex;

    }
}