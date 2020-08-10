namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CSV = new System.Windows.Forms.Button();
            this.TXT = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.machine = new System.Windows.Forms.TextBox();
            this.dbs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.badresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CSV
            // 
            this.CSV.Location = new System.Drawing.Point(80, 188);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(75, 23);
            this.CSV.TabIndex = 0;
            this.CSV.Text = "CSV";
            this.CSV.UseVisualStyleBackColor = true;
            this.CSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT
            // 
            this.TXT.Location = new System.Drawing.Point(251, 188);
            this.TXT.Name = "TXT";
            this.TXT.Size = new System.Drawing.Size(75, 23);
            this.TXT.TabIndex = 1;
            this.TXT.Text = "TXT";
            this.TXT.UseMnemonic = false;
            this.TXT.UseVisualStyleBackColor = true;
            this.TXT.Click += new System.EventHandler(this.TXT_Click);
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(48, 25);
            this.query.Multiline = true;
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(324, 95);
            this.query.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type the query here:";
            // 
            // machine
            // 
            this.machine.Location = new System.Drawing.Point(80, 139);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(100, 20);
            this.machine.TabIndex = 4;
            // 
            // dbs
            // 
            this.dbs.Location = new System.Drawing.Point(226, 139);
            this.dbs.Name = "dbs";
            this.dbs.Size = new System.Drawing.Size(100, 20);
            this.dbs.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MachineName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.Color.LawnGreen;
            this.result.Location = new System.Drawing.Point(102, 146);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 8;
            // 
            // badresult
            // 
            this.badresult.AutoSize = true;
            this.badresult.ForeColor = System.Drawing.Color.Red;
            this.badresult.Location = new System.Drawing.Point(108, 146);
            this.badresult.Name = "badresult";
            this.badresult.Size = new System.Drawing.Size(0, 13);
            this.badresult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(410, 252);
            this.Controls.Add(this.badresult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbs);
            this.Controls.Add(this.machine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query);
            this.Controls.Add(this.TXT);
            this.Controls.Add(this.CSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SQLReportMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CSV;
        private System.Windows.Forms.Button TXT;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox machine;
        private System.Windows.Forms.TextBox dbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label badresult;
    }
}

