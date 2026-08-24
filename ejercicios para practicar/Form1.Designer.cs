namespace ejercicios_para_practicar
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
            label1 = new Label();
            txtDatos = new TextBox();
            ltsResultados = new ListBox();
            btnProcesar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 82);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "serie:";
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(93, 75);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(206, 27);
            txtDatos.TabIndex = 1;
            txtDatos.TextChanged += txtDatos_TextChanged;
            // 
            // ltsResultados
            // 
            ltsResultados.FormattingEnabled = true;
            ltsResultados.Location = new Point(37, 160);
            ltsResultados.Name = "ltsResultados";
            ltsResultados.Size = new Size(262, 224);
            ltsResultados.TabIndex = 2;
            ltsResultados.SelectedIndexChanged += ltsResultados_SelectedIndexChanged;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(387, 39);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(182, 105);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(387, 279);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(182, 105);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 420);
            Controls.Add(btnLimpiar);
            Controls.Add(btnProcesar);
            Controls.Add(ltsResultados);
            Controls.Add(txtDatos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDatos;
        private ListBox ltsResultados;
        private Button btnProcesar;
        private Button btnLimpiar;
    }
}
