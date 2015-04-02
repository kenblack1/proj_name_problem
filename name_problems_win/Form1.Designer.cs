namespace name_problems_win
{
    partial class frmNames
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
            this.lvNames = new System.Windows.Forms.ListView();
            this.btnLoadNames = new System.Windows.Forms.Button();
            this.btnCalculateScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvNames
            // 
            this.lvNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvNames.Location = new System.Drawing.Point(0, 97);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(970, 389);
            this.lvNames.TabIndex = 3;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.View = System.Windows.Forms.View.List;
            // 
            // btnLoadNames
            // 
            this.btnLoadNames.Location = new System.Drawing.Point(12, 52);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(232, 39);
            this.btnLoadNames.TabIndex = 0;
            this.btnLoadNames.Text = "Load Names";
            this.btnLoadNames.UseVisualStyleBackColor = true;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // btnCalculateScore
            // 
            this.btnCalculateScore.Location = new System.Drawing.Point(263, 52);
            this.btnCalculateScore.Name = "btnCalculateScore";
            this.btnCalculateScore.Size = new System.Drawing.Size(232, 39);
            this.btnCalculateScore.TabIndex = 4;
            this.btnCalculateScore.Text = "Calculate Score";
            this.btnCalculateScore.UseVisualStyleBackColor = true;
            this.btnCalculateScore.Click += new System.EventHandler(this.btnCalculateScore_Click);
            // 
            // frmNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 486);
            this.Controls.Add(this.btnCalculateScore);
            this.Controls.Add(this.lvNames);
            this.Controls.Add(this.btnLoadNames);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNames";
            this.Text = "Name";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.Button btnLoadNames;
        private System.Windows.Forms.Button btnCalculateScore;
    }
}

