namespace ElectronicCircles
{
    partial class Password
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
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // pass
            // 
            // 
            // 
            // 
            this.pass.CustomButton.Image = null;
            this.pass.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.pass.CustomButton.Name = "";
            this.pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass.CustomButton.TabIndex = 1;
            this.pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass.CustomButton.UseSelectable = true;
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(22, 63);
            this.pass.MaxLength = 32767;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '•';
            this.pass.PromptText = "Введіть пароль";
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.ShowButton = true;
            this.pass.Size = new System.Drawing.Size(318, 23);
            this.pass.TabIndex = 0;
            this.pass.UseSelectable = true;
            this.pass.WaterMark = "Введіть пароль";
            this.pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(310, 95);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(30, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Ок";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 143);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.pass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 143);
            this.MinimumSize = new System.Drawing.Size(364, 143);
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox pass;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}