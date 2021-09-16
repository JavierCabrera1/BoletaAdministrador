
namespace BoletasUsuario
{
    partial class ReportePresencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excel_btn = new System.Windows.Forms.Button();
            this.buscar_btn = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.desde_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.excel_btn);
            this.groupBox1.Controls.Add(this.buscar_btn);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.desde_lbl);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(807, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 75);
            this.groupBox1.TabIndex = 61;
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
            this.excel_btn.Location = new System.Drawing.Point(273, 33);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(34, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 40);
            this.label4.TabIndex = 60;
            this.label4.Text = "Reporte de Presencia";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(41, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 401);
            this.dataGridView1.TabIndex = 62;
            // 
            // ReportePresencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoletasUsuario.Properties.Resources.FONDO_4;
            this.ClientSize = new System.Drawing.Size(1161, 642);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "ReportePresencia";
            this.Text = "ReportePresencia";
            this.Load += new System.EventHandler(this.ReportePresencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button excel_btn;
        private System.Windows.Forms.Button buscar_btn;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label desde_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}