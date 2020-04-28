namespace articulos
{
    partial class listadoarticulos
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
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.beditar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(35, 57);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(796, 299);
            this.dgvlistado.TabIndex = 0;
            // 
            // beditar
            // 
            this.beditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.beditar.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.beditar.Location = new System.Drawing.Point(148, 416);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(136, 48);
            this.beditar.TabIndex = 1;
            this.beditar.Text = "Editar";
            this.beditar.UseVisualStyleBackColor = false;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.beliminar.Font = new System.Drawing.Font("Noto Sans", 11.25F, System.Drawing.FontStyle.Bold);
            this.beliminar.Location = new System.Drawing.Point(388, 416);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(136, 48);
            this.beliminar.TabIndex = 2;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            // 
            // listadoarticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 547);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.beditar);
            this.Controls.Add(this.dgvlistado);
            this.Name = "listadoarticulos";
            this.Text = "listadoarticulos";
            this.Load += new System.EventHandler(this.listadoarticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.Button beliminar;
    }
}