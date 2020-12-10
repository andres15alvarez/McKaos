
namespace Presentacion
{
    partial class PEstadisticasVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtpfechafinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gdvventas = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnproductos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnestadisticasdolar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadisticas de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dtpfechainicial
            // 
            this.dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicial.Location = new System.Drawing.Point(131, 71);
            this.dtpfechainicial.Name = "dtpfechainicial";
            this.dtpfechainicial.Size = new System.Drawing.Size(124, 27);
            this.dtpfechainicial.TabIndex = 2;
            // 
            // dtpfechafinal
            // 
            this.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafinal.Location = new System.Drawing.Point(360, 71);
            this.dtpfechafinal.Name = "dtpfechafinal";
            this.dtpfechafinal.Size = new System.Drawing.Size(124, 27);
            this.dtpfechafinal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Final:";
            // 
            // gdvventas
            // 
            this.gdvventas.AllowUserToAddRows = false;
            this.gdvventas.AllowUserToDeleteRows = false;
            this.gdvventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.gdvventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Constantia", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gdvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(86)))), ((int)(((byte)(149)))));
            this.gdvventas.Location = new System.Drawing.Point(18, 121);
            this.gdvventas.MultiSelect = false;
            this.gdvventas.Name = "gdvventas";
            this.gdvventas.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Constantia", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Constantia", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gdvventas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gdvventas.Size = new System.Drawing.Size(562, 197);
            this.gdvventas.TabIndex = 6;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.Location = new System.Drawing.Point(490, 67);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 37);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total vendido:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(131, 399);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(150, 27);
            this.txttotal.TabIndex = 9;
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(428, 399);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.ReadOnly = true;
            this.txtpromedio.Size = new System.Drawing.Size(150, 27);
            this.txtpromedio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Promedio:";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(131, 471);
            this.txtmax.Name = "txtmax";
            this.txtmax.ReadOnly = true;
            this.txtmax.Size = new System.Drawing.Size(150, 27);
            this.txtmax.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Venta maxina:";
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(428, 471);
            this.txtmin.Name = "txtmin";
            this.txtmin.ReadOnly = true;
            this.txtmin.Size = new System.Drawing.Size(150, 27);
            this.txtmin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Venta minima:";
            // 
            // btnproductos
            // 
            this.btnproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnproductos.Location = new System.Drawing.Point(18, 324);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(276, 29);
            this.btnproductos.TabIndex = 16;
            this.btnproductos.Text = "Ver lista de productos vendidos";
            this.btnproductos.UseVisualStyleBackColor = false;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(249, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estadisticas";
            // 
            // btnestadisticasdolar
            // 
            this.btnestadisticasdolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.btnestadisticasdolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnestadisticasdolar.FlatAppearance.BorderSize = 0;
            this.btnestadisticasdolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestadisticasdolar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnestadisticasdolar.Location = new System.Drawing.Point(360, 519);
            this.btnestadisticasdolar.Name = "btnestadisticasdolar";
            this.btnestadisticasdolar.Size = new System.Drawing.Size(218, 29);
            this.btnestadisticasdolar.TabIndex = 18;
            this.btnestadisticasdolar.Text = "Ver estadisticas en dolares\r\n";
            this.btnestadisticasdolar.UseVisualStyleBackColor = false;
            this.btnestadisticasdolar.Click += new System.EventHandler(this.btnestadisticasdolar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ingrese el rango de fechas que desea consultar";
            // 
            // PEstadisticasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(592, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnestadisticasdolar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gdvventas);
            this.Controls.Add(this.dtpfechafinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechainicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PEstadisticasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.gdvventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfechainicial;
        private System.Windows.Forms.DateTimePicker dtpfechafinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdvventas;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnestadisticasdolar;
        private System.Windows.Forms.Label label9;
    }
}