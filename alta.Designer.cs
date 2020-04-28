namespace articulos
{
    partial class alta
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
            this.lcodigo = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.lmarca = new System.Windows.Forms.Label();
            this.lurl = new System.Windows.Forms.Label();
            this.tcodigo = new System.Windows.Forms.TextBox();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.turl = new System.Windows.Forms.TextBox();
            this.baceptar = new System.Windows.Forms.Button();
            this.ldescripcion = new System.Windows.Forms.Label();
            this.tdescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lacategoria = new System.Windows.Forms.Label();
            this.lprecio = new System.Windows.Forms.Label();
            this.tprecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lcodigo
            // 
            this.lcodigo.AutoSize = true;
            this.lcodigo.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lcodigo.Location = new System.Drawing.Point(61, 35);
            this.lcodigo.Name = "lcodigo";
            this.lcodigo.Size = new System.Drawing.Size(52, 18);
            this.lcodigo.TabIndex = 0;
            this.lcodigo.Text = "Codigo";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lnombre.Location = new System.Drawing.Point(61, 80);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(62, 18);
            this.lnombre.TabIndex = 1;
            this.lnombre.Text = "Nombre";
            // 
            // lmarca
            // 
            this.lmarca.AutoSize = true;
            this.lmarca.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lmarca.Location = new System.Drawing.Point(64, 172);
            this.lmarca.Name = "lmarca";
            this.lmarca.Size = new System.Drawing.Size(49, 18);
            this.lmarca.TabIndex = 3;
            this.lmarca.Text = "Marca";
            this.lmarca.Click += new System.EventHandler(this.lmarca_Click);
            // 
            // lurl
            // 
            this.lurl.AutoSize = true;
            this.lurl.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lurl.Location = new System.Drawing.Point(64, 271);
            this.lurl.Name = "lurl";
            this.lurl.Size = new System.Drawing.Size(100, 18);
            this.lurl.TabIndex = 5;
            this.lurl.Text = "Url de imagen";
            // 
            // tcodigo
            // 
            this.tcodigo.Location = new System.Drawing.Point(218, 33);
            this.tcodigo.Name = "tcodigo";
            this.tcodigo.Size = new System.Drawing.Size(202, 20);
            this.tcodigo.TabIndex = 7;
            // 
            // tnombre
            // 
            this.tnombre.Location = new System.Drawing.Point(218, 77);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(202, 20);
            this.tnombre.TabIndex = 8;
            this.tnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // turl
            // 
            this.turl.Location = new System.Drawing.Point(218, 271);
            this.turl.Name = "turl";
            this.turl.Size = new System.Drawing.Size(297, 20);
            this.turl.TabIndex = 12;
            // 
            // baceptar
            // 
            this.baceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.baceptar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar.Location = new System.Drawing.Point(204, 373);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(126, 42);
            this.baceptar.TabIndex = 14;
            this.baceptar.Text = "Aceptar";
            this.baceptar.UseVisualStyleBackColor = false;
            this.baceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ldescripcion
            // 
            this.ldescripcion.AutoSize = true;
            this.ldescripcion.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ldescripcion.Location = new System.Drawing.Point(61, 123);
            this.ldescripcion.Name = "ldescripcion";
            this.ldescripcion.Size = new System.Drawing.Size(85, 18);
            this.ldescripcion.TabIndex = 15;
            this.ldescripcion.Text = "Descripcion";
            // 
            // tdescripcion
            // 
            this.tdescripcion.Location = new System.Drawing.Point(218, 121);
            this.tdescripcion.Name = "tdescripcion";
            this.tdescripcion.Size = new System.Drawing.Size(202, 20);
            this.tdescripcion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // lacategoria
            // 
            this.lacategoria.AutoSize = true;
            this.lacategoria.Font = new System.Drawing.Font("Noto Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lacategoria.Location = new System.Drawing.Point(67, 230);
            this.lacategoria.Name = "lacategoria";
            this.lacategoria.Size = new System.Drawing.Size(72, 18);
            this.lacategoria.TabIndex = 20;
            this.lacategoria.Text = "Categoria";
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Font = new System.Drawing.Font("Noto Sans Cond", 11.25F, System.Drawing.FontStyle.Bold);
            this.lprecio.Location = new System.Drawing.Point(64, 319);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(49, 20);
            this.lprecio.TabIndex = 21;
            this.lprecio.Text = "Precio";
            // 
            // tprecio
            // 
            this.tprecio.Location = new System.Drawing.Point(218, 319);
            this.tprecio.Name = "tprecio";
            this.tprecio.Size = new System.Drawing.Size(202, 20);
            this.tprecio.TabIndex = 22;
            // 
            // alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(537, 472);
            this.Controls.Add(this.tprecio);
            this.Controls.Add(this.lprecio);
            this.Controls.Add(this.lacategoria);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdescripcion);
            this.Controls.Add(this.ldescripcion);
            this.Controls.Add(this.baceptar);
            this.Controls.Add(this.turl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tnombre);
            this.Controls.Add(this.tcodigo);
            this.Controls.Add(this.lurl);
            this.Controls.Add(this.lmarca);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.lcodigo);
            this.Name = "alta";
            this.Text = "alta";
            this.Load += new System.EventHandler(this.alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lcodigo;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lmarca;
        private System.Windows.Forms.Label lurl;
        private System.Windows.Forms.TextBox tcodigo;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox turl;
        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.Label ldescripcion;
        private System.Windows.Forms.TextBox tdescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lacategoria;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.TextBox tprecio;
    }
}