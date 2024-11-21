namespace Codigo2024Clase28
{
    partial class Form3
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
            dgvClientes = new DataGridView();
            btnBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtContacto = new TextBox();
            txtCargo = new TextBox();
            dgvClientesCargados = new DataGridView();
            btnCargar = new Button();
            btnBuscarNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesCargados).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(60, 150);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(659, 188);
            dgvClientes.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(488, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar DT";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 101);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Cargo";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(135, 98);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 4;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(344, 102);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 27);
            txtCargo.TabIndex = 5;
            // 
            // dgvClientesCargados
            // 
            dgvClientesCargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesCargados.Location = new Point(60, 401);
            dgvClientesCargados.Name = "dgvClientesCargados";
            dgvClientesCargados.RowHeadersWidth = 51;
            dgvClientesCargados.Size = new Size(659, 188);
            dgvClientesCargados.TabIndex = 6;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(579, 353);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnBuscarNew
            // 
            btnBuscarNew.Location = new Point(615, 105);
            btnBuscarNew.Name = "btnBuscarNew";
            btnBuscarNew.Size = new Size(94, 29);
            btnBuscarNew.TabIndex = 8;
            btnBuscarNew.Text = "Buscar";
            btnBuscarNew.UseVisualStyleBackColor = true;
            btnBuscarNew.Click += btnBuscarNew_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(btnBuscarNew);
            Controls.Add(btnCargar);
            Controls.Add(dgvClientesCargados);
            Controls.Add(txtCargo);
            Controls.Add(txtContacto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(dgvClientes);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesCargados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnBuscar;
        private Label label1;
        private Label label2;
        private TextBox txtContacto;
        private TextBox txtCargo;
        private DataGridView dgvClientesCargados;
        private Button btnCargar;
        private Button btnBuscarNew;
    }
}