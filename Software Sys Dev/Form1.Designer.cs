namespace Software_Sys_Dev
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog_loadStock = new System.Windows.Forms.OpenFileDialog();
            this.button_loadStock = new System.Windows.Forms.Button();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.candleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_loadStock
            // 
            this.openFileDialog_loadStock.Filter = "All Stock Files (*.csv)|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Mon" +
    "thly Stocks|*-Month.csv";
            this.openFileDialog_loadStock.InitialDirectory = "..\\..\\..\\..\\Stock Data";
            this.openFileDialog_loadStock.Multiselect = true;
            this.openFileDialog_loadStock.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_loadStock_FileOk);
            // 
            // button_loadStock
            // 
            this.button_loadStock.Location = new System.Drawing.Point(519, 217);
            this.button_loadStock.Name = "button_loadStock";
            this.button_loadStock.Size = new System.Drawing.Size(218, 23);
            this.button_loadStock.TabIndex = 8;
            this.button_loadStock.Text = "Load Stock";
            this.button_loadStock.UseVisualStyleBackColor = true;
            this.button_loadStock.Click += new System.EventHandler(this.button_loadStock_Click);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Location = new System.Drawing.Point(516, 97);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker_To.TabIndex = 13;
            this.dateTimePicker_To.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(516, 150);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker_From.TabIndex = 14;
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(516, 75);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(24, 16);
            this.label_To.TabIndex = 15;
            this.label_To.Text = "To";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(516, 126);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(38, 16);
            this.label_From.TabIndex = 16;
            this.label_From.Text = "From";
            // 
            // candleStickBindingSource
            // 
            this.candleStickBindingSource.DataSource = typeof(Software_Sys_Dev.candleStick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1222, 369);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.dateTimePicker_To);
            this.Controls.Add(this.button_loadStock);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadStock;
        private System.Windows.Forms.Button button_loadStock;
        private System.Windows.Forms.BindingSource candleStickBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
    }
}

