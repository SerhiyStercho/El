namespace ElectronicCircles
{
    partial class TestResult
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
            this.circularPB1 = new AltoControls.CircularPB();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // circularPB1
            // 
            this.circularPB1.AllowText = true;
            this.circularPB1.AutomaticFontCalculation = true;
            this.circularPB1.BackColor = System.Drawing.Color.Transparent;
            this.circularPB1.Location = new System.Drawing.Point(14, 109);
            this.circularPB1.MaxValue = 100;
            this.circularPB1.MinimumSize = new System.Drawing.Size(60, 60);
            this.circularPB1.MinValue = 0;
            this.circularPB1.Name = "circularPB1";
            this.circularPB1.ProgressColor = System.Drawing.Color.LightBlue;
            this.circularPB1.Size = new System.Drawing.Size(213, 213);
            this.circularPB1.Stroke = 10;
            this.circularPB1.TabIndex = 0;
            this.circularPB1.Text = "circularPB1";
            this.circularPB1.Transparency = true;
            this.circularPB1.Value = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Правильних відповідей";
            // 
            // TestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 364);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.circularPB1);
            this.Name = "TestResult";
            this.Text = "TestResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.CircularPB circularPB1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}