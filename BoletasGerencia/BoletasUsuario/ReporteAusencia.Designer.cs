
namespace BoletasUsuario
{
    partial class ReporteAusencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excel_btn = new System.Windows.Forms.Button();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.desde_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(32, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 40);
            this.label4.TabIndex = 58;
            this.label4.Text = "Reporte de Ausencia";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.excel_btn);
            this.groupBox1.Controls.Add(this.buscar_btn);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.desde_lbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(666, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 75);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // excel_btn
            // 
            this.excel_btn.BackColor = System.Drawing.Color.Transparent;
            this.excel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel_btn.Image = global::BoletasUsuario.Properties.Resources.Logo_excel_opt;
            this.excel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excel_btn.Location = new System.Drawing.Point(273, 32);
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.Size = new System.Drawing.Size(34, 30);
            this.excel_btn.TabIndex = 53;
            this.excel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excel_btn.UseVisualStyleBackColor = false;
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // buscar_btn
            // 
            this.buscar_btn.BackColor = System.Drawing.Color.White;
            this.buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_btn.Image = global::BoletasUsuario.Properties.Resources.busqueda__1_;
            this.buscar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar_btn.Location = new System.Drawing.Point(160, 32);
            this.buscar_btn.Name = "buscar_btn";
            this.buscar_btn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buscar_btn.Size = new System.Drawing.Size(87, 30);
            this.buscar_btn.TabIndex = 4;
            this.buscar_btn.Text = "Buscar";
            this.buscar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar_btn.UseVisualStyleBackColor = false;
            this.buscar_btn.Click += new System.EventHandler(this.buscar_btn_Click);
            // 
            // fecha
            // 
            this.fecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(9, 32);
            this.fecha.MaximumSize = new System.Drawing.Size(120, 30);
            this.fecha.MinimumSize = new System.Drawing.Size(120, 30);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(120, 30);
            this.fecha.TabIndex = 2;
            // 
            // desde_lbl
            // 
            this.desde_lbl.AutoSize = true;
            this.desde_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde_lbl.Location = new System.Drawing.Point(6, 12);
            this.desde_lbl.Name = "desde_lbl";
            this.desde_lbl.Size = new System.Drawing.Size(41, 17);
            this.desde_lbl.TabIndex = 0;
            this.desde_lbl.Text = "Filtrar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(39, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 379);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "escoja una fecha";
            // 
            // ReporteAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoletasUsuario.Properties.Resources.FONDO_4;
            this.ClientSize = new System.Drawing.Size(1018, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "ReporteAusencia";
            this.Text = "ReporteAusencia";
            this.Load += new System.EventHandler(this.ReporteAusencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button excel_btn;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label desde_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}