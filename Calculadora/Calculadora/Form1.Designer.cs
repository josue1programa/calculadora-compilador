namespace Calculadora
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
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSiete = new Button();
            btnOcho = new Button();
            btnNueve = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(28, 26);
            txtResultado.MaxLength = 16;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(314, 66);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.Location = new Point(28, 353);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(74, 74);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.Location = new Point(108, 354);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(74, 74);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.Location = new Point(188, 354);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(74, 74);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.Location = new Point(28, 273);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(74, 74);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.Location = new Point(108, 274);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(74, 74);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeis.Location = new Point(188, 274);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(74, 74);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.Location = new Point(28, 194);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(74, 74);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.Location = new Point(108, 194);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(74, 74);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.Location = new Point(188, 194);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(74, 74);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(28, 114);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 74);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(108, 114);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(74, 74);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "←";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSumar.Location = new Point(268, 274);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(74, 74);
            btnSumar.TabIndex = 13;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestar.Location = new Point(268, 194);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(74, 74);
            btnRestar.TabIndex = 14;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(188, 114);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(74, 74);
            btnMultiplicar.TabIndex = 15;
            btnMultiplicar.Tag = "*";
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDividir.Location = new Point(268, 114);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(74, 74);
            btnDividir.TabIndex = 16;
            btnDividir.Tag = "/";
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(28, 434);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(74, 74);
            btnPunto.TabIndex = 17;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.Location = new Point(108, 434);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(154, 74);
            btnCero.TabIndex = 18;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.Location = new Point(268, 354);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(74, 154);
            btnIgual.TabIndex = 19;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(381, 539);
            Controls.Add(btnIgual);
            Controls.Add(btnCero);
            Controls.Add(btnPunto);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnBorrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora C sharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnPunto;
        private Button btnCero;
        private Button btnIgual;
    }
}