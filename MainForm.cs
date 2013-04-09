using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Colors
{
    public partial class MainForm : Form
    {
        Timer timer;
        Bitmap src;
        Color currentColor;
        bool pickActive;

        public MainForm()
        {
            InitializeComponent();
            fChooseColorButton.Click += new EventHandler(OnChooseColorButtonClick);
            pickActive = false;
            currentColor = this.BackColor;
            fColorPanel.BringToFront();

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(OnTimerTick);
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            UpdateBitmap();

            if (src != null)
            {
                //currentColor = src.GetPixel(fPictureBoxPreview.Width / 2, fPictureBoxPreview.Height / 2);
                fColorPanel.BackColor = currentColor;
                fHexText.Text =
                    ToHex(currentColor.R) +
                    ToHex(currentColor.G) +
                    ToHex(currentColor.B);

                fRedText.Text = currentColor.R.ToString();
                fGreenText.Text = currentColor.G.ToString();
                fBlueText.Text = currentColor.B.ToString();

                //fColorLabel.Text += "HSB: " + clr.GetBrightness();
            }
        }

        string ToHex(int input)
        {
            string ret = Convert.ToString(input, 16).ToUpper();
            return ret.Length == 1 ? "0" + ret : ret;
        }

        void OnChooseColorButtonClick(object sender, EventArgs e)
        {
            if (fChooseColorButton.Text == "Pick")
            {
                fChooseColorButton.Text = "Stop";
                UpdateBitmap();
                timer.Start();
                this.TopMost = true;
                pickActive = true;

                fPictureBoxPreview.BringToFront();
            }
            else
            {
                fChooseColorButton.Text = "Pick";
                timer.Stop();
                this.TopMost = false;
                pickActive = false;

                if (src != null) 
                    src.Dispose();
                if (fPictureBoxPreview.Image != null)
                {
                    fPictureBoxPreview.Image.Dispose();
                    fPictureBoxPreview.Image = null;
                }

                fColorPanel.BringToFront();
            }
        }

        void UpdateBitmap()
        {
            if (src != null)
                src.Dispose();
            if (fPictureBoxPreview.Image != null)
                fPictureBoxPreview.Image.Dispose();

            int srcwidth = fPictureBoxPreview.Width;
            int srcheight = fPictureBoxPreview.Height;
            int scale = 4;

            // Capture the screen around the cursor
            src = new Bitmap(srcwidth, srcheight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfx = Graphics.FromImage(src);
            gfx.CopyFromScreen(
                Cursor.Position.X - (srcwidth / 2),
                Cursor.Position.Y - (srcheight / 2),
                0,
                0,
                new Size(srcwidth, srcheight),
                CopyPixelOperation.SourceCopy);

            // Scale up the image
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            gfx.DrawImage(src, new Rectangle(
                    -(srcwidth) / 2 - fPictureBoxPreview.Width,
                    -(srcheight) / 2 - fPictureBoxPreview.Height,
                    srcwidth * scale,
                    srcheight * scale));

            // Update the color value
            currentColor = src.GetPixel(fPictureBoxPreview.Width / 2, fPictureBoxPreview.Height / 2);

            // Draw helper lines
            SolidBrush sb = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
            gfx.FillRectangle(sb, 0, srcheight / 2 - (scale / 2), (srcwidth / 2) - (scale / 2), scale);
            gfx.FillRectangle(sb, (srcwidth / 2) + (scale / 2), srcheight / 2 - (scale / 2), (srcwidth / 2), scale);

            gfx.FillRectangle(sb, srcwidth / 2 - (scale / 2), 0, scale, srcheight / 2 - (scale / 2));
            gfx.FillRectangle(sb, srcwidth / 2 - (scale / 2), srcheight / 2 + (scale / 2), scale, srcheight / 2);
            sb.Dispose();

            // Set the picturebox image
            fPictureBoxPreview.Image = src;

            gfx.Dispose();
        }

        private void OnRGBTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnHexTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!IsHex(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool IsHex(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        }

        private void OnRGBTextChanged(object sender, EventArgs e)
        {
            if (!pickActive)
            {
                TextBox Sender = sender as TextBox;
                int value = 0;
                if (Sender.Text != "")
                    value = int.Parse(Sender.Text);
                if (value > 255)
                    Sender.Text = "255";

                if (!fHexText.Focused && fRedText.Text != "" && fGreenText.Text != "" && fBlueText.Text != "")
                {
                    currentColor = Color.FromArgb(
                            int.Parse(fRedText.Text),
                            int.Parse(fGreenText.Text),
                            int.Parse(fBlueText.Text));

                    fColorPanel.BackColor = currentColor;

                    fHexText.Text =
                        ToHex(currentColor.R) +
                        ToHex(currentColor.G) +
                        ToHex(currentColor.B);
                }
            }
        }

        private void OnHexTextChanged(object sender, EventArgs e)
        {
            if (!pickActive && fHexText.Text.Length == 6 && !fRedText.Focused && !fGreenText.Focused && !fBlueText.Focused)
            {
                string hexString = fHexText.Text;
                currentColor = Color.FromArgb(
                    Int32.Parse(hexString.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                    Int32.Parse(hexString.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                    Int32.Parse(hexString.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));

                fColorPanel.BackColor = currentColor;
                fRedText.Text = currentColor.R.ToString();
                fGreenText.Text = currentColor.G.ToString();
                fBlueText.Text = currentColor.B.ToString();
            }

            if (fCheckBoxCopyHex.Checked)
            {
                Clipboard.SetText(fHexText.Text);
            }
        }

        private void OnTextboxClick(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
