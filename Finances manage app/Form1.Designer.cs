namespace Finances_manage_app
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noboxamount = new System.Windows.Forms.NumericUpDown();
            this.txtboxname = new System.Windows.Forms.TextBox();
            this.ablamount = new System.Windows.Forms.Label();
            this.btnaddexpensetotranslog = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.btnshowallexpenses = new System.Windows.Forms.Button();
            this.btnshowexpenseswithsameamount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxExpenses = new System.Windows.Forms.ListBox();
            this.noboxamount2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noboxamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noboxamount2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noboxamount);
            this.groupBox1.Controls.Add(this.txtboxname);
            this.groupBox1.Controls.Add(this.ablamount);
            this.groupBox1.Controls.Add(this.btnaddexpensetotranslog);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense form";
            // 
            // noboxamount
            // 
            this.noboxamount.DecimalPlaces = 2;
            this.noboxamount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.noboxamount.Location = new System.Drawing.Point(125, 87);
            this.noboxamount.Name = "noboxamount";
            this.noboxamount.Size = new System.Drawing.Size(205, 30);
            this.noboxamount.TabIndex = 8;
            // 
            // txtboxname
            // 
            this.txtboxname.Location = new System.Drawing.Point(132, 41);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.Size = new System.Drawing.Size(198, 30);
            this.txtboxname.TabIndex = 2;
            // 
            // ablamount
            // 
            this.ablamount.AutoSize = true;
            this.ablamount.Location = new System.Drawing.Point(30, 89);
            this.ablamount.Name = "ablamount";
            this.ablamount.Size = new System.Drawing.Size(86, 25);
            this.ablamount.TabIndex = 1;
            this.ablamount.Text = "Amount:";
            // 
            // btnaddexpensetotranslog
            // 
            this.btnaddexpensetotranslog.Location = new System.Drawing.Point(157, 149);
            this.btnaddexpensetotranslog.Name = "btnaddexpensetotranslog";
            this.btnaddexpensetotranslog.Size = new System.Drawing.Size(173, 69);
            this.btnaddexpensetotranslog.TabIndex = 3;
            this.btnaddexpensetotranslog.Text = "Add expense to transaction log";
            this.btnaddexpensetotranslog.UseVisualStyleBackColor = true;
            this.btnaddexpensetotranslog.Click += new System.EventHandler(this.btnaddexpensetotranslog_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(30, 41);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // btnshowallexpenses
            // 
            this.btnshowallexpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowallexpenses.Location = new System.Drawing.Point(31, 293);
            this.btnshowallexpenses.Name = "btnshowallexpenses";
            this.btnshowallexpenses.Size = new System.Drawing.Size(341, 42);
            this.btnshowallexpenses.TabIndex = 3;
            this.btnshowallexpenses.Text = "Show all expenses";
            this.btnshowallexpenses.UseVisualStyleBackColor = true;
            this.btnshowallexpenses.Click += new System.EventHandler(this.btnshowallexpenses_Click);
            // 
            // btnshowexpenseswithsameamount
            // 
            this.btnshowexpenseswithsameamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowexpenseswithsameamount.Location = new System.Drawing.Point(31, 402);
            this.btnshowexpenseswithsameamount.Name = "btnshowexpenseswithsameamount";
            this.btnshowexpenseswithsameamount.Size = new System.Drawing.Size(341, 36);
            this.btnshowexpenseswithsameamount.TabIndex = 4;
            this.btnshowexpenseswithsameamount.Text = "Show expenses with same amount";
            this.btnshowexpenseswithsameamount.UseVisualStyleBackColor = true;
            this.btnshowexpenseswithsameamount.Click += new System.EventHandler(this.btnshowexpenseswithsameamount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount:";
            // 
            // listBoxExpenses
            // 
            this.listBoxExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExpenses.FormattingEnabled = true;
            this.listBoxExpenses.ItemHeight = 25;
            this.listBoxExpenses.Items.AddRange(new object[] {
            " "});
            this.listBoxExpenses.Location = new System.Drawing.Point(418, 44);
            this.listBoxExpenses.Name = "listBoxExpenses";
            this.listBoxExpenses.Size = new System.Drawing.Size(337, 354);
            this.listBoxExpenses.TabIndex = 6;
            // 
            // noboxamount2
            // 
            this.noboxamount2.DecimalPlaces = 2;
            this.noboxamount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noboxamount2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.noboxamount2.Location = new System.Drawing.Point(115, 358);
            this.noboxamount2.Name = "noboxamount2";
            this.noboxamount2.Size = new System.Drawing.Size(257, 30);
            this.noboxamount2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noboxamount2);
            this.Controls.Add(this.listBoxExpenses);
            this.Controls.Add(this.btnshowexpenseswithsameamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowallexpenses);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noboxamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noboxamount2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxname;
        private System.Windows.Forms.Label ablamount;
        private System.Windows.Forms.Button btnaddexpensetotranslog;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnshowallexpenses;
        private System.Windows.Forms.Button btnshowexpenseswithsameamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxExpenses;
        private System.Windows.Forms.NumericUpDown noboxamount;
        private System.Windows.Forms.NumericUpDown noboxamount2;
    }
}

