namespace ElectronicCircles
{
    partial class nameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameForm));
            this.inputName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputName
            // 
            // 
            // 
            // 
            this.inputName.CustomButton.Image = null;
            this.inputName.CustomButton.Location = new System.Drawing.Point(387, 1);
            this.inputName.CustomButton.Name = "";
            this.inputName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputName.CustomButton.TabIndex = 1;
            this.inputName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputName.CustomButton.UseSelectable = true;
            this.inputName.CustomButton.Visible = false;
            this.inputName.DisplayIcon = true;
            this.inputName.Icon = ((System.Drawing.Image)(resources.GetObject("inputName.Icon")));
            this.inputName.Lines = new string[0];
            this.inputName.Location = new System.Drawing.Point(13, 95);
            this.inputName.MaxLength = 32767;
            this.inputName.Name = "inputName";
            this.inputName.PasswordChar = '\0';
            this.inputName.PromptText = "Введіть ПІБ";
            this.inputName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputName.SelectedText = "";
            this.inputName.SelectionLength = 0;
            this.inputName.SelectionStart = 0;
            this.inputName.ShortcutsEnabled = true;
            this.inputName.Size = new System.Drawing.Size(409, 23);
            this.inputName.TabIndex = 2;
            this.inputName.UseSelectable = true;
            this.inputName.WaterMark = "Введіть ПІБ";
            this.inputName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(13, 130);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(409, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // nameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 176);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.inputName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 176);
            this.MinimumSize = new System.Drawing.Size(434, 176);
            this.Name = "nameForm";
            this.Text = "Введіть ПІБ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nameForm_FormClosed);
            this.Load += new System.EventHandler(this.nameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox inputName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}