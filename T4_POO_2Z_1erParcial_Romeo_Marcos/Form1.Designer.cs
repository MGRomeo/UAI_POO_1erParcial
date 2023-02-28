namespace T4_POO_2Z_1erParcial_Romeo_Marcos
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
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.dgvAdelanto = new System.Windows.Forms.DataGridView();
            this.dgvAdelantoEmpleado = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtImporteOtorgado = new System.Windows.Forms.TextBox();
            this.rdbOperario = new System.Windows.Forms.RadioButton();
            this.txtSaldoAdeudado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdbAdministrativo = new System.Windows.Forms.RadioButton();
            this.rdbDirectivo = new System.Windows.Forms.RadioButton();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelanto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantoEmpleado)).BeginInit();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(12, 77);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(426, 181);
            this.dgvEmpleado.TabIndex = 0;
            // 
            // dgvAdelanto
            // 
            this.dgvAdelanto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelanto.Location = new System.Drawing.Point(577, 77);
            this.dgvAdelanto.Name = "dgvAdelanto";
            this.dgvAdelanto.Size = new System.Drawing.Size(548, 181);
            this.dgvAdelanto.TabIndex = 1;
            // 
            // dgvAdelantoEmpleado
            // 
            this.dgvAdelantoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantoEmpleado.Location = new System.Drawing.Point(577, 312);
            this.dgvAdelantoEmpleado.Name = "dgvAdelantoEmpleado";
            this.dgvAdelantoEmpleado.Size = new System.Drawing.Size(548, 150);
            this.dgvAdelantoEmpleado.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(424, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 26);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema Adelantos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adelantos Existentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adelantos por Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldos";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(461, 128);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(81, 71);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar Adelanto";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtImporteOtorgado
            // 
            this.txtImporteOtorgado.Location = new System.Drawing.Point(22, 455);
            this.txtImporteOtorgado.Multiline = true;
            this.txtImporteOtorgado.Name = "txtImporteOtorgado";
            this.txtImporteOtorgado.Size = new System.Drawing.Size(120, 88);
            this.txtImporteOtorgado.TabIndex = 9;
            // 
            // rdbOperario
            // 
            this.rdbOperario.AutoSize = true;
            this.rdbOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOperario.Location = new System.Drawing.Point(5, 23);
            this.rdbOperario.Name = "rdbOperario";
            this.rdbOperario.Size = new System.Drawing.Size(82, 21);
            this.rdbOperario.TabIndex = 11;
            this.rdbOperario.TabStop = true;
            this.rdbOperario.Text = "Operario";
            this.rdbOperario.UseVisualStyleBackColor = true;
            // 
            // txtSaldoAdeudado
            // 
            this.txtSaldoAdeudado.Location = new System.Drawing.Point(197, 455);
            this.txtSaldoAdeudado.Multiline = true;
            this.txtSaldoAdeudado.Name = "txtSaldoAdeudado";
            this.txtSaldoAdeudado.Size = new System.Drawing.Size(124, 88);
            this.txtSaldoAdeudado.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1050, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdbAdministrativo
            // 
            this.rdbAdministrativo.AutoSize = true;
            this.rdbAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdministrativo.Location = new System.Drawing.Point(6, 59);
            this.rdbAdministrativo.Name = "rdbAdministrativo";
            this.rdbAdministrativo.Size = new System.Drawing.Size(114, 21);
            this.rdbAdministrativo.TabIndex = 14;
            this.rdbAdministrativo.TabStop = true;
            this.rdbAdministrativo.Text = "Administrativo";
            this.rdbAdministrativo.UseVisualStyleBackColor = true;
            // 
            // rdbDirectivo
            // 
            this.rdbDirectivo.AutoSize = true;
            this.rdbDirectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDirectivo.Location = new System.Drawing.Point(6, 100);
            this.rdbDirectivo.Name = "rdbDirectivo";
            this.rdbDirectivo.Size = new System.Drawing.Size(81, 21);
            this.rdbDirectivo.TabIndex = 15;
            this.rdbDirectivo.TabStop = true;
            this.rdbDirectivo.Text = "Directivo";
            this.rdbDirectivo.UseVisualStyleBackColor = true;
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbDirectivo);
            this.gpbTipo.Controls.Add(this.rdbOperario);
            this.gpbTipo.Controls.Add(this.rdbAdministrativo);
            this.gpbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipo.Location = new System.Drawing.Point(22, 264);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(130, 127);
            this.gpbTipo.TabIndex = 17;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo :";
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(197, 264);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(124, 32);
            this.btnCarga.TabIndex = 18;
            this.btnCarga.Text = "Nuevo Empleado";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(197, 312);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 32);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar Empleado";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(197, 359);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 32);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar Empleado";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(577, 468);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(75, 47);
            this.btnPago.TabIndex = 21;
            this.btnPago.Text = "Generar pago";
            this.btnPago.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 555);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtSaldoAdeudado);
            this.Controls.Add(this.txtImporteOtorgado);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvAdelantoEmpleado);
            this.Controls.Add(this.dgvAdelanto);
            this.Controls.Add(this.dgvEmpleado);
            this.Name = "Form1";
            this.Text = "Sistema Adelantos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelanto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantoEmpleado)).EndInit();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridView dgvAdelanto;
        private System.Windows.Forms.DataGridView dgvAdelantoEmpleado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtImporteOtorgado;
        private System.Windows.Forms.RadioButton rdbOperario;
        private System.Windows.Forms.TextBox txtSaldoAdeudado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdbAdministrativo;
        private System.Windows.Forms.RadioButton rdbDirectivo;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPago;
    }
}

