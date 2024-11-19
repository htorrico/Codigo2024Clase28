namespace Codigo2024Clase28
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
            dgvCategorias = new DataGridView();
            btnListarCategorias = new Button();
            button1 = new Button();
            button2 = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            btnGrabar = new Button();
            btnGrabarProcedimiento = new Button();
            txtDescripcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(26, 176);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(738, 262);
            dgvCategorias.TabIndex = 0;
            // 
            // btnListarCategorias
            // 
            btnListarCategorias.Location = new Point(26, 141);
            btnListarCategorias.Name = "btnListarCategorias";
            btnListarCategorias.Size = new Size(140, 29);
            btnListarCategorias.TabIndex = 1;
            btnListarCategorias.Text = "Listar Categorias";
            btnListarCategorias.UseVisualStyleBackColor = true;
            btnListarCategorias.Click += btnListarCategorias_Click;
            // 
            // button1
            // 
            button1.Location = new Point(181, 141);
            button1.Name = "button1";
            button1.Size = new Size(205, 29);
            button1.TabIndex = 2;
            button1.Text = "Listar Categorias User SQL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(392, 141);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 3;
            button2.Text = "Listar Categorias Using";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(38, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(383, 35);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnGrabarProcedimiento
            // 
            btnGrabarProcedimiento.Location = new Point(483, 35);
            btnGrabarProcedimiento.Name = "btnGrabarProcedimiento";
            btnGrabarProcedimiento.Size = new Size(185, 29);
            btnGrabarProcedimiento.TabIndex = 7;
            btnGrabarProcedimiento.Text = "Grabar Procedimiento";
            btnGrabarProcedimiento.UseVisualStyleBackColor = true;
            btnGrabarProcedimiento.Click += btnGrabarProcedimiento_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(38, 77);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(296, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGrabarProcedimiento);
            Controls.Add(btnGrabar);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnListarCategorias);
            Controls.Add(dgvCategorias);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private Button btnListarCategorias;
        private Button button1;
        private Button button2;
        private TextBox txtID;
        private TextBox txtName;
        private Button btnGrabar;
        private Button btnGrabarProcedimiento;
        private TextBox txtDescripcion;
    }
}
