namespace SG_Barcode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txt_width = new TextBox();
            txt_Height = new TextBox();
            btn_print = new Button();
            cbo_types = new ComboBox();
            btn_generar = new Button();
            panel4 = new Panel();
            txtData = new TextBox();
            pnl_Barcodes = new Panel();
            sfd_SaveBarcodes = new SaveFileDialog();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 254);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1210, 254);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_width);
            panel3.Controls.Add(txt_Height);
            panel3.Controls.Add(btn_print);
            panel3.Controls.Add(cbo_types);
            panel3.Controls.Add(btn_generar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(913, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 248);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 145);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 6;
            label2.Text = "Ancho:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 102);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 5;
            label1.Text = "Alto:";
            // 
            // txt_width
            // 
            txt_width.Location = new Point(88, 142);
            txt_width.Name = "txt_width";
            txt_width.Size = new Size(171, 31);
            txt_width.TabIndex = 4;
            txt_width.Text = "250";
            // 
            // txt_Height
            // 
            txt_Height.Location = new Point(88, 99);
            txt_Height.Name = "txt_Height";
            txt_Height.Size = new Size(171, 31);
            txt_Height.TabIndex = 3;
            txt_Height.Text = "80";
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.SteelBlue;
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btn_print.ForeColor = SystemColors.ControlLight;
            btn_print.Location = new Point(156, 9);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(129, 72);
            btn_print.TabIndex = 2;
            btn_print.Text = "IMPRIMIR";
            btn_print.UseVisualStyleBackColor = false;
            // 
            // cbo_types
            // 
            cbo_types.FormattingEnabled = true;
            cbo_types.Location = new Point(15, 193);
            cbo_types.Name = "cbo_types";
            cbo_types.Size = new Size(270, 33);
            cbo_types.TabIndex = 1;
            // 
            // btn_generar
            // 
            btn_generar.BackColor = Color.ForestGreen;
            btn_generar.FlatStyle = FlatStyle.Flat;
            btn_generar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btn_generar.ForeColor = SystemColors.ControlLight;
            btn_generar.Location = new Point(15, 9);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(129, 72);
            btn_generar.TabIndex = 0;
            btn_generar.Text = "GENERAR";
            btn_generar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtData);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(904, 248);
            panel4.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Dock = DockStyle.Fill;
            txtData.Location = new Point(0, 0);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.Size = new Size(904, 248);
            txtData.TabIndex = 1;
            // 
            // pnl_Barcodes
            // 
            pnl_Barcodes.Dock = DockStyle.Fill;
            pnl_Barcodes.Location = new Point(0, 254);
            pnl_Barcodes.Name = "pnl_Barcodes";
            pnl_Barcodes.Size = new Size(1210, 388);
            pnl_Barcodes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 642);
            Controls.Add(pnl_Barcodes);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnl_Barcodes;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button btn_generar;
        private Panel panel4;
        private TextBox txtData;
        private ComboBox cbo_types;
        private Button btn_print;
        private SaveFileDialog sfd_SaveBarcodes;
        private Label label2;
        private Label label1;
        private TextBox txt_width;
        private TextBox txt_Height;
    }
}
