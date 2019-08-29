namespace CadastroDeNascimento
{
    partial class frmconsultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxConsulta = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.dtConsulta = new System.Windows.Forms.DataGridView();
            this.lbParamentro = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Por";
            // 
            // boxConsulta
            // 
            this.boxConsulta.FormattingEnabled = true;
            this.boxConsulta.Items.AddRange(new object[] {
            "Data de registro",
            "Nome do Registrado",
            "Data de Nascimento",
            "Hora de Nascimento",
            "Nome do Pai",
            "Nome da Mae",
            "Numero DNV ou DO"});
            this.boxConsulta.Location = new System.Drawing.Point(96, 11);
            this.boxConsulta.Name = "boxConsulta";
            this.boxConsulta.Size = new System.Drawing.Size(121, 20);
            this.boxConsulta.TabIndex = 1;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(96, 47);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(121, 18);
            this.txtParametro.TabIndex = 2;
            // 
            // dtConsulta
            // 
            this.dtConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtConsulta.Location = new System.Drawing.Point(12, 79);
            this.dtConsulta.Name = "dtConsulta";
            this.dtConsulta.Size = new System.Drawing.Size(709, 284);
            this.dtConsulta.TabIndex = 3;
            // 
            // lbParamentro
            // 
            this.lbParamentro.AutoSize = true;
            this.lbParamentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParamentro.Location = new System.Drawing.Point(12, 49);
            this.lbParamentro.Name = "lbParamentro";
            this.lbParamentro.Size = new System.Drawing.Size(55, 13);
            this.lbParamentro.TabIndex = 4;
            this.lbParamentro.Text = "Parametro";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(674, 379);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 21);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Deixar parametros em branco para consultar todos";
            // 
            // frmconsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lbParamentro);
            this.Controls.Add(this.dtConsulta);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.boxConsulta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmconsultar";
            this.Text = "Consultar Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dtConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxConsulta;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.DataGridView dtConsulta;
        private System.Windows.Forms.Label lbParamentro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
    }
}