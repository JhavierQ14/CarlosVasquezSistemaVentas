
namespace SistemaVentasP2.VISTA
{
    partial class FrmAgregarUsuarios
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
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveUsuario = new System.Windows.Forms.Button();
            this.btnUpdateUsuario = new System.Windows.Forms.Button();
            this.txtIdUsuarios = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(70, 164);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(88, 31);
            this.btnAgregarUsuarios.TabIndex = 9;
            this.btnAgregarUsuarios.Text = "Agregar";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = true;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(181, 114);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(201, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese una nuevo email y una contraseña";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(425, 253);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contraseña";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnRemoveUsuario
            // 
            this.btnRemoveUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUsuario.Location = new System.Drawing.Point(179, 164);
            this.btnRemoveUsuario.Name = "btnRemoveUsuario";
            this.btnRemoveUsuario.Size = new System.Drawing.Size(88, 31);
            this.btnRemoveUsuario.TabIndex = 12;
            this.btnRemoveUsuario.Text = "Eliminar";
            this.btnRemoveUsuario.UseVisualStyleBackColor = true;
            this.btnRemoveUsuario.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateUsuario
            // 
            this.btnUpdateUsuario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsuario.Location = new System.Drawing.Point(294, 164);
            this.btnUpdateUsuario.Name = "btnUpdateUsuario";
            this.btnUpdateUsuario.Size = new System.Drawing.Size(88, 31);
            this.btnUpdateUsuario.TabIndex = 13;
            this.btnUpdateUsuario.Text = "Actualizar";
            this.btnUpdateUsuario.UseVisualStyleBackColor = true;
            this.btnUpdateUsuario.Click += new System.EventHandler(this.btnUpdateUsuario_Click);
            // 
            // txtIdUsuarios
            // 
            this.txtIdUsuarios.Location = new System.Drawing.Point(24, 69);
            this.txtIdUsuarios.Name = "txtIdUsuarios";
            this.txtIdUsuarios.Size = new System.Drawing.Size(44, 20);
            this.txtIdUsuarios.TabIndex = 14;
            this.txtIdUsuarios.Visible = false;
            // 
            // FrmAgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 473);
            this.Controls.Add(this.txtIdUsuarios);
            this.Controls.Add(this.btnUpdateUsuario);
            this.Controls.Add(this.btnRemoveUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Name = "FrmAgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoveUsuario;
        private System.Windows.Forms.Button btnUpdateUsuario;
        private System.Windows.Forms.TextBox txtIdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}