namespace Codigo2024Clase28
{
    partial class Form2
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
            dgvProductos = new DataGridView();
            btnListar = new Button();
            btnListarProcedimiento = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(60, 218);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(480, 188);
            dgvProductos.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(73, 148);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(94, 29);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnListarProcedimiento
            // 
            btnListarProcedimiento.Location = new Point(203, 148);
            btnListarProcedimiento.Name = "btnListarProcedimiento";
            btnListarProcedimiento.Size = new Size(166, 29);
            btnListarProcedimiento.TabIndex = 2;
            btnListarProcedimiento.Text = "Listar Procedimientos";
            btnListarProcedimiento.UseVisualStyleBackColor = true;
            btnListarProcedimiento.Click += btnListarProcedimiento_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarProcedimiento);
            Controls.Add(btnListar);
            Controls.Add(dgvProductos);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnListar;
        private Button btnListarProcedimiento;
    }
}