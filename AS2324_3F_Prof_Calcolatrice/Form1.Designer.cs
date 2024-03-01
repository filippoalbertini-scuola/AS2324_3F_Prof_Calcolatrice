namespace AS2324_3F_Prof_Calcolatrice
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
            txtOperando1 = new TextBox();
            txtOperando2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcola = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            lblRisultato = new Label();
            SuspendLayout();
            // 
            // txtOperando1
            // 
            txtOperando1.Location = new Point(202, 36);
            txtOperando1.Name = "txtOperando1";
            txtOperando1.Size = new Size(125, 27);
            txtOperando1.TabIndex = 0;
            // 
            // txtOperando2
            // 
            txtOperando2.Location = new Point(202, 100);
            txtOperando2.Name = "txtOperando2";
            txtOperando2.Size = new Size(125, 27);
            txtOperando2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Operando 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Operando 2";
            // 
            // btnCalcola
            // 
            btnCalcola.Location = new Point(220, 219);
            btnCalcola.Name = "btnCalcola";
            btnCalcola.Size = new Size(94, 29);
            btnCalcola.TabIndex = 2;
            btnCalcola.Text = "=";
            btnCalcola.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-", "+", "*", "/" });
            comboBox1.Location = new Point(229, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(71, 28);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 164);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "Operazione";
            // 
            // lblRisultato
            // 
            lblRisultato.AutoSize = true;
            lblRisultato.Location = new Point(185, 293);
            lblRisultato.Name = "lblRisultato";
            lblRisultato.Size = new Size(74, 20);
            lblRisultato.TabIndex = 1;
            lblRisultato.Text = "Risultato :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 361);
            Controls.Add(comboBox1);
            Controls.Add(btnCalcola);
            Controls.Add(lblRisultato);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOperando2);
            Controls.Add(txtOperando1);
            Name = "Form1";
            Text = "Prof; 3F; 01/03/24; Calcolatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperando1;
        private TextBox txtOperando2;
        private Label label1;
        private Label label2;
        private Button btnCalcola;
        private ComboBox comboBox1;
        private Label label3;
        private Label lblRisultato;
    }
}
