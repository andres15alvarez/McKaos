
namespace Presentacion
{
    partial class Menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelusuario = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelconfiguracion = new System.Windows.Forms.Panel();
            this.btnactualizarusuario = new System.Windows.Forms.Button();
            this.btncrearusuario = new System.Windows.Forms.Button();
            this.btnconfiguracion = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.panelcompras = new System.Windows.Forms.Panel();
            this.btnestadisticascompras = new System.Windows.Forms.Button();
            this.btnguardarcompras = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.panelventas = new System.Windows.Forms.Panel();
            this.btnestadisticasventas = new System.Windows.Forms.Button();
            this.btnprocesarventas = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelusuario.SuspendLayout();
            this.panelconfiguracion.SuspendLayout();
            this.panelcompras.SuspendLayout();
            this.panelventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.panelMenu.Controls.Add(this.panelusuario);
            this.panelMenu.Controls.Add(this.panelconfiguracion);
            this.panelMenu.Controls.Add(this.btnconfiguracion);
            this.panelMenu.Controls.Add(this.btninventario);
            this.panelMenu.Controls.Add(this.panelcompras);
            this.panelMenu.Controls.Add(this.btncompras);
            this.panelMenu.Controls.Add(this.panelventas);
            this.panelMenu.Controls.Add(this.btnventas);
            this.panelMenu.Controls.Add(this.piclogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelusuario
            // 
            this.panelusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.panelusuario.Controls.Add(this.btnsalir);
            this.panelusuario.Controls.Add(this.lbltipo);
            this.panelusuario.Controls.Add(this.lblnombre);
            this.panelusuario.Controls.Add(this.label1);
            this.panelusuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelusuario.Location = new System.Drawing.Point(0, 510);
            this.panelusuario.Name = "panelusuario";
            this.panelusuario.Size = new System.Drawing.Size(175, 144);
            this.panelusuario.TabIndex = 6;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btnsalir.Location = new System.Drawing.Point(0, 116);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(175, 28);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.lbltipo.Location = new System.Drawing.Point(12, 78);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(53, 19);
            this.lbltipo.TabIndex = 4;
            this.lbltipo.Text = "Tipo: ";
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.lblnombre.Location = new System.Drawing.Point(12, 34);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 19);
            this.lblnombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido (a)";
            // 
            // panelconfiguracion
            // 
            this.panelconfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.panelconfiguracion.Controls.Add(this.btnactualizarusuario);
            this.panelconfiguracion.Controls.Add(this.btncrearusuario);
            this.panelconfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelconfiguracion.Location = new System.Drawing.Point(0, 430);
            this.panelconfiguracion.Name = "panelconfiguracion";
            this.panelconfiguracion.Size = new System.Drawing.Size(175, 80);
            this.panelconfiguracion.TabIndex = 7;
            // 
            // btnactualizarusuario
            // 
            this.btnactualizarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btnactualizarusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnactualizarusuario.FlatAppearance.BorderSize = 0;
            this.btnactualizarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarusuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnactualizarusuario.Location = new System.Drawing.Point(0, 40);
            this.btnactualizarusuario.Name = "btnactualizarusuario";
            this.btnactualizarusuario.Size = new System.Drawing.Size(175, 40);
            this.btnactualizarusuario.TabIndex = 2;
            this.btnactualizarusuario.Text = "Actualizar Usuario";
            this.btnactualizarusuario.UseVisualStyleBackColor = false;
            this.btnactualizarusuario.Click += new System.EventHandler(this.btnactualizarusuario_Click);
            // 
            // btncrearusuario
            // 
            this.btncrearusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btncrearusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncrearusuario.FlatAppearance.BorderSize = 0;
            this.btncrearusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearusuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btncrearusuario.Location = new System.Drawing.Point(0, 0);
            this.btncrearusuario.Name = "btncrearusuario";
            this.btncrearusuario.Size = new System.Drawing.Size(175, 40);
            this.btncrearusuario.TabIndex = 1;
            this.btncrearusuario.Text = "Crear Usuario";
            this.btncrearusuario.UseVisualStyleBackColor = false;
            this.btncrearusuario.Click += new System.EventHandler(this.btncrearusuario_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btnconfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconfiguracion.FlatAppearance.BorderSize = 0;
            this.btnconfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfiguracion.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btnconfiguracion.Location = new System.Drawing.Point(0, 390);
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Size = new System.Drawing.Size(175, 40);
            this.btnconfiguracion.TabIndex = 6;
            this.btnconfiguracion.Text = "Configuracion";
            this.btnconfiguracion.UseVisualStyleBackColor = false;
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
            // 
            // btninventario
            // 
            this.btninventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btninventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninventario.FlatAppearance.BorderSize = 0;
            this.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventario.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btninventario.Location = new System.Drawing.Point(0, 350);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(175, 40);
            this.btninventario.TabIndex = 5;
            this.btninventario.Text = "Inventario";
            this.btninventario.UseVisualStyleBackColor = false;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // panelcompras
            // 
            this.panelcompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.panelcompras.Controls.Add(this.btnestadisticascompras);
            this.panelcompras.Controls.Add(this.btnguardarcompras);
            this.panelcompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcompras.Location = new System.Drawing.Point(0, 270);
            this.panelcompras.Name = "panelcompras";
            this.panelcompras.Size = new System.Drawing.Size(175, 80);
            this.panelcompras.TabIndex = 4;
            // 
            // btnestadisticascompras
            // 
            this.btnestadisticascompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btnestadisticascompras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnestadisticascompras.FlatAppearance.BorderSize = 0;
            this.btnestadisticascompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestadisticascompras.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnestadisticascompras.Location = new System.Drawing.Point(0, 40);
            this.btnestadisticascompras.Name = "btnestadisticascompras";
            this.btnestadisticascompras.Size = new System.Drawing.Size(175, 40);
            this.btnestadisticascompras.TabIndex = 1;
            this.btnestadisticascompras.Text = "Estadisticas Compras";
            this.btnestadisticascompras.UseVisualStyleBackColor = false;
            this.btnestadisticascompras.Click += new System.EventHandler(this.btnestadisticascompras_Click);
            // 
            // btnguardarcompras
            // 
            this.btnguardarcompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btnguardarcompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnguardarcompras.FlatAppearance.BorderSize = 0;
            this.btnguardarcompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcompras.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnguardarcompras.Location = new System.Drawing.Point(0, 0);
            this.btnguardarcompras.Name = "btnguardarcompras";
            this.btnguardarcompras.Size = new System.Drawing.Size(175, 40);
            this.btnguardarcompras.TabIndex = 0;
            this.btnguardarcompras.Text = "Guardar Compras";
            this.btnguardarcompras.UseVisualStyleBackColor = false;
            this.btnguardarcompras.Click += new System.EventHandler(this.btnguardarcompras_Click);
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btncompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btncompras.Location = new System.Drawing.Point(0, 230);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(175, 40);
            this.btncompras.TabIndex = 3;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // panelventas
            // 
            this.panelventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.panelventas.Controls.Add(this.btnestadisticasventas);
            this.panelventas.Controls.Add(this.btnprocesarventas);
            this.panelventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelventas.Location = new System.Drawing.Point(0, 150);
            this.panelventas.Name = "panelventas";
            this.panelventas.Size = new System.Drawing.Size(175, 80);
            this.panelventas.TabIndex = 2;
            // 
            // btnestadisticasventas
            // 
            this.btnestadisticasventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btnestadisticasventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnestadisticasventas.FlatAppearance.BorderSize = 0;
            this.btnestadisticasventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestadisticasventas.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnestadisticasventas.Location = new System.Drawing.Point(0, 40);
            this.btnestadisticasventas.Name = "btnestadisticasventas";
            this.btnestadisticasventas.Size = new System.Drawing.Size(175, 40);
            this.btnestadisticasventas.TabIndex = 1;
            this.btnestadisticasventas.Text = "Estadisticas Ventas";
            this.btnestadisticasventas.UseVisualStyleBackColor = false;
            this.btnestadisticasventas.Click += new System.EventHandler(this.btnestadisticasventas_Click);
            // 
            // btnprocesarventas
            // 
            this.btnprocesarventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(45)))), ((int)(((byte)(79)))));
            this.btnprocesarventas.FlatAppearance.BorderSize = 0;
            this.btnprocesarventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocesarventas.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnprocesarventas.Location = new System.Drawing.Point(0, 0);
            this.btnprocesarventas.Name = "btnprocesarventas";
            this.btnprocesarventas.Size = new System.Drawing.Size(192, 40);
            this.btnprocesarventas.TabIndex = 0;
            this.btnprocesarventas.Text = "Procesar Ventas";
            this.btnprocesarventas.UseVisualStyleBackColor = false;
            this.btnprocesarventas.Click += new System.EventHandler(this.btnprocesarventas_Click);
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(13)))), ((int)(((byte)(21)))));
            this.btnventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold);
            this.btnventas.Location = new System.Drawing.Point(0, 110);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(175, 40);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // piclogo
            // 
            this.piclogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.piclogo.Image = global::Presentacion.Properties.Resources.mckaos_preview_rev_2;
            this.piclogo.Location = new System.Drawing.Point(0, 0);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(175, 110);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.AutoScroll = true;
            this.panelcontenedor.AutoScrollMinSize = new System.Drawing.Size(0, 560);
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(14)))), ((int)(((byte)(54)))));
            this.panelcontenedor.Controls.Add(this.lblinfo);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(192, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(592, 561);
            this.panelcontenedor.TabIndex = 1;
            // 
            // lblinfo
            // 
            this.lblinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Bold);
            this.lblinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinfo.Location = new System.Drawing.Point(78, 300);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(450, 27);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Selecciona una opcion del menu izquierdo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Constantia", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelusuario.ResumeLayout(false);
            this.panelusuario.PerformLayout();
            this.panelconfiguracion.ResumeLayout(false);
            this.panelcompras.ResumeLayout(false);
            this.panelventas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
            this.panelcontenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelusuario;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Panel panelcompras;
        private System.Windows.Forms.Button btnestadisticascompras;
        private System.Windows.Forms.Button btnguardarcompras;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Panel panelventas;
        private System.Windows.Forms.Button btnestadisticasventas;
        private System.Windows.Forms.Button btnprocesarventas;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Panel panelconfiguracion;
        private System.Windows.Forms.Button btnactualizarusuario;
        private System.Windows.Forms.Button btncrearusuario;
        private System.Windows.Forms.Button btnconfiguracion;
        private System.Windows.Forms.PictureBox piclogo;
    }
}