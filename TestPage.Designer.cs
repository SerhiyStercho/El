namespace ElectronicCircles
{
    partial class TestPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPage));
            this.question1 = new MetroFramework.Controls.MetroButton();
            this.ans1 = new MetroFramework.Controls.MetroButton();
            this.ans2 = new MetroFramework.Controls.MetroButton();
            this.ans3 = new MetroFramework.Controls.MetroButton();
            this.ans4 = new MetroFramework.Controls.MetroButton();
            this.ans5 = new MetroFramework.Controls.MetroButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.right_answer = new MaterialSkin.Controls.MaterialLabel();
            this.wrong_answer = new MaterialSkin.Controls.MaterialLabel();
            this.exitTest = new MaterialSkin.Controls.MaterialFlatButton();
            this.next = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backnew2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // question1
            // 
            this.question1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.question1.Location = new System.Drawing.Point(367, 669);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(117, 23);
            this.question1.TabIndex = 2;
            this.question1.Text = "1";
            this.question1.UseSelectable = true;
            this.question1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ans1
            // 
            this.ans1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ans1.Location = new System.Drawing.Point(199, 524);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(454, 23);
            this.ans1.TabIndex = 18;
            this.ans1.Text = "1";
            this.ans1.UseSelectable = true;
            this.ans1.Click += new System.EventHandler(this.ans1_Click);
            // 
            // ans2
            // 
            this.ans2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ans2.Location = new System.Drawing.Point(199, 553);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(454, 23);
            this.ans2.TabIndex = 18;
            this.ans2.Text = "2";
            this.ans2.UseSelectable = true;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // ans3
            // 
            this.ans3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ans3.Location = new System.Drawing.Point(199, 582);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(454, 23);
            this.ans3.TabIndex = 18;
            this.ans3.Text = "3";
            this.ans3.UseSelectable = true;
            this.ans3.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // ans4
            // 
            this.ans4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ans4.Location = new System.Drawing.Point(199, 611);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(454, 23);
            this.ans4.TabIndex = 18;
            this.ans4.Text = "4";
            this.ans4.UseSelectable = true;
            this.ans4.Click += new System.EventHandler(this.ans4_Click);
            // 
            // ans5
            // 
            this.ans5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ans5.Location = new System.Drawing.Point(199, 640);
            this.ans5.Name = "ans5";
            this.ans5.Size = new System.Drawing.Size(454, 23);
            this.ans5.TabIndex = 18;
            this.ans5.Text = "5";
            this.ans5.UseSelectable = true;
            this.ans5.Click += new System.EventHandler(this.ans5_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Red;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 553);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Неправильно";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.LimeGreen;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(745, 553);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Правильно";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // right_answer
            // 
            this.right_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.right_answer.AutoSize = true;
            this.right_answer.Depth = 0;
            this.right_answer.Font = new System.Drawing.Font("Roboto", 11F);
            this.right_answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.right_answer.Location = new System.Drawing.Point(722, 553);
            this.right_answer.MouseState = MaterialSkin.MouseState.HOVER;
            this.right_answer.Name = "right_answer";
            this.right_answer.Size = new System.Drawing.Size(17, 19);
            this.right_answer.TabIndex = 23;
            this.right_answer.Text = "0";
            this.right_answer.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // wrong_answer
            // 
            this.wrong_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wrong_answer.AutoSize = true;
            this.wrong_answer.Depth = 0;
            this.wrong_answer.Font = new System.Drawing.Font("Roboto", 11F);
            this.wrong_answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrong_answer.Location = new System.Drawing.Point(115, 553);
            this.wrong_answer.MouseState = MaterialSkin.MouseState.HOVER;
            this.wrong_answer.Name = "wrong_answer";
            this.wrong_answer.Size = new System.Drawing.Size(17, 19);
            this.wrong_answer.TabIndex = 23;
            this.wrong_answer.Text = "0";
            // 
            // exitTest
            // 
            this.exitTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitTest.AutoSize = true;
            this.exitTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitTest.Depth = 0;
            this.exitTest.Location = new System.Drawing.Point(682, 656);
            this.exitTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitTest.Name = "exitTest";
            this.exitTest.Primary = false;
            this.exitTest.Size = new System.Drawing.Size(132, 36);
            this.exitTest.TabIndex = 24;
            this.exitTest.Text = "Завершити тест";
            this.exitTest.UseVisualStyleBackColor = true;
            this.exitTest.Click += new System.EventHandler(this.exitTest_Click);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.next.BackgroundImage = global::ElectronicCircles.ButB.next2;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.next.Location = new System.Drawing.Point(490, 669);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(27, 23);
            this.next.TabIndex = 26;
            this.next.UseSelectable = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(24, 81);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(791, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // backnew2
            // 
            this.backnew2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backnew2.BackgroundImage = global::ElectronicCircles.ButB.back2;
            this.backnew2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backnew2.Location = new System.Drawing.Point(334, 669);
            this.backnew2.Name = "backnew2";
            this.backnew2.Size = new System.Drawing.Size(27, 23);
            this.backnew2.TabIndex = 27;
            this.backnew2.UseSelectable = true;
            this.backnew2.Click += new System.EventHandler(this.backnew2_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 698);
            this.Controls.Add(this.backnew2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exitTest);
            this.Controls.Add(this.wrong_answer);
            this.Controls.Add(this.right_answer);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ans5);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.question1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestPage";
            this.Text = "Тест";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestPage_FormClosing);
            this.Load += new System.EventHandler(this.TestPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton question1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton ans1;
        private MetroFramework.Controls.MetroButton ans2;
        private MetroFramework.Controls.MetroButton ans3;
        private MetroFramework.Controls.MetroButton ans4;
        private MetroFramework.Controls.MetroButton ans5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel right_answer;
        private MaterialSkin.Controls.MaterialLabel wrong_answer;
        private MaterialSkin.Controls.MaterialFlatButton exitTest;
        private MetroFramework.Controls.MetroButton next;
        private MetroFramework.Controls.MetroButton backnew2;
    }
}