namespace PrimeiraAplicacao
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
            button_calcular = new Button();
            label_title = new Label();
            label_thread = new Label();
            label_valor_inicial = new Label();
            label_valor_final = new Label();
            label_resultado = new Label();
            textBox_valor_inicial = new TextBox();
            textBox_resultado = new TextBox();
            textBox_valor_final = new TextBox();
            label_stack = new Label();
            textBox_valor_da_variavel_valor_final = new TextBox();
            textBox_valor_da_variavel_resultado = new TextBox();
            textBox_valor_da_variavel_valor_inicial = new TextBox();
            label_valor_da_variavel_resultado = new Label();
            label_valor_da_variavel_valor_final = new Label();
            label_valor_da_variavel_valor_inicial = new Label();
            label_topo_da_pilha = new Label();
            button_empilhar_resultado = new Button();
            button_empilhar_valor_final = new Button();
            button_empilhar_valor_inicial = new Button();
            SuspendLayout();
            // 
            // button_calcular
            // 
            button_calcular.Location = new Point(113, 246);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(100, 32);
            button_calcular.TabIndex = 0;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = true;
            button_calcular.Click += button1_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Location = new Point(251, 23);
            label_title.Name = "label_title";
            label_title.Size = new Size(258, 15);
            label_title.TabIndex = 1;
            label_title.Text = "GERENCIAMENTO DE MEMÓRIA STACK (PILHA)";
            // 
            // label_thread
            // 
            label_thread.AutoSize = true;
            label_thread.Location = new Point(18, 67);
            label_thread.Name = "label_thread";
            label_thread.Size = new Size(43, 15);
            label_thread.TabIndex = 2;
            label_thread.Text = "Thread";
            // 
            // label_valor_inicial
            // 
            label_valor_inicial.AutoSize = true;
            label_valor_inicial.Location = new Point(21, 110);
            label_valor_inicial.Name = "label_valor_inicial";
            label_valor_inicial.Size = new Size(86, 15);
            label_valor_inicial.TabIndex = 3;
            label_valor_inicial.Text = "int valor_inicial";
            // 
            // label_valor_final
            // 
            label_valor_final.AutoSize = true;
            label_valor_final.Location = new Point(21, 140);
            label_valor_final.Name = "label_valor_final";
            label_valor_final.Size = new Size(78, 15);
            label_valor_final.TabIndex = 4;
            label_valor_final.Text = "int valor_final";
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Location = new Point(21, 173);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(73, 15);
            label_resultado.TabIndex = 5;
            label_resultado.Text = "int resultado";
            // 
            // textBox_valor_inicial
            // 
            textBox_valor_inicial.Location = new Point(113, 107);
            textBox_valor_inicial.Name = "textBox_valor_inicial";
            textBox_valor_inicial.Size = new Size(100, 23);
            textBox_valor_inicial.TabIndex = 6;
            // 
            // textBox_resultado
            // 
            textBox_resultado.Enabled = false;
            textBox_resultado.Location = new Point(113, 167);
            textBox_resultado.Name = "textBox_resultado";
            textBox_resultado.Size = new Size(100, 23);
            textBox_resultado.TabIndex = 7;
            textBox_resultado.TextChanged += textBox_resultado_TextChanged;
            // 
            // textBox_valor_final
            // 
            textBox_valor_final.Location = new Point(113, 137);
            textBox_valor_final.Name = "textBox_valor_final";
            textBox_valor_final.Size = new Size(100, 23);
            textBox_valor_final.TabIndex = 8;
            // 
            // label_stack
            // 
            label_stack.AutoSize = true;
            label_stack.Location = new Point(357, 68);
            label_stack.Name = "label_stack";
            label_stack.Size = new Size(35, 15);
            label_stack.TabIndex = 9;
            label_stack.Text = "Stack";
            // 
            // textBox_valor_da_variavel_valor_final
            // 
            textBox_valor_da_variavel_valor_final.Enabled = false;
            textBox_valor_da_variavel_valor_final.Location = new Point(685, 136);
            textBox_valor_da_variavel_valor_final.Name = "textBox_valor_da_variavel_valor_final";
            textBox_valor_da_variavel_valor_final.Size = new Size(100, 23);
            textBox_valor_da_variavel_valor_final.TabIndex = 15;
            // 
            // textBox_valor_da_variavel_resultado
            // 
            textBox_valor_da_variavel_resultado.Enabled = false;
            textBox_valor_da_variavel_resultado.Location = new Point(685, 106);
            textBox_valor_da_variavel_resultado.Name = "textBox_valor_da_variavel_resultado";
            textBox_valor_da_variavel_resultado.Size = new Size(100, 23);
            textBox_valor_da_variavel_resultado.TabIndex = 14;
            // 
            // textBox_valor_da_variavel_valor_inicial
            // 
            textBox_valor_da_variavel_valor_inicial.Enabled = false;
            textBox_valor_da_variavel_valor_inicial.Location = new Point(685, 169);
            textBox_valor_da_variavel_valor_inicial.Name = "textBox_valor_da_variavel_valor_inicial";
            textBox_valor_da_variavel_valor_inicial.Size = new Size(100, 23);
            textBox_valor_da_variavel_valor_inicial.TabIndex = 13;
            // 
            // label_valor_da_variavel_resultado
            // 
            label_valor_da_variavel_resultado.AutoSize = true;
            label_valor_da_variavel_resultado.Location = new Point(357, 110);
            label_valor_da_variavel_resultado.Name = "label_valor_da_variavel_resultado";
            label_valor_da_variavel_resultado.Size = new Size(310, 15);
            label_valor_da_variavel_resultado.TabIndex = 12;
            label_valor_da_variavel_resultado.Text = "4 bytes de memória para armazenar o valor de (resultado)";
            // 
            // label_valor_da_variavel_valor_final
            // 
            label_valor_da_variavel_valor_final.AutoSize = true;
            label_valor_da_variavel_valor_final.Location = new Point(357, 141);
            label_valor_da_variavel_valor_final.Name = "label_valor_da_variavel_valor_final";
            label_valor_da_variavel_valor_final.Size = new Size(315, 15);
            label_valor_da_variavel_valor_final.TabIndex = 11;
            label_valor_da_variavel_valor_final.Text = "4 bytes de memória para armazenar o valor de (valor_final)";
            // 
            // label_valor_da_variavel_valor_inicial
            // 
            label_valor_da_variavel_valor_inicial.AutoSize = true;
            label_valor_da_variavel_valor_inicial.Location = new Point(357, 173);
            label_valor_da_variavel_valor_inicial.Name = "label_valor_da_variavel_valor_inicial";
            label_valor_da_variavel_valor_inicial.Size = new Size(323, 15);
            label_valor_da_variavel_valor_inicial.TabIndex = 10;
            label_valor_da_variavel_valor_inicial.Text = "4 bytes de memória para armazenar o valor de (valor_inicial)";
            // 
            // label_topo_da_pilha
            // 
            label_topo_da_pilha.AutoSize = true;
            label_topo_da_pilha.Location = new Point(801, 110);
            label_topo_da_pilha.Name = "label_topo_da_pilha";
            label_topo_da_pilha.Size = new Size(79, 15);
            label_topo_da_pilha.TabIndex = 16;
            label_topo_da_pilha.Text = "Topo da stack";
            // 
            // button_empilhar_resultado
            // 
            button_empilhar_resultado.Location = new Point(219, 167);
            button_empilhar_resultado.Name = "button_empilhar_resultado";
            button_empilhar_resultado.Size = new Size(132, 22);
            button_empilhar_resultado.TabIndex = 17;
            button_empilhar_resultado.Text = "Empilhar Resultado";
            button_empilhar_resultado.UseVisualStyleBackColor = true;
            button_empilhar_resultado.Click += button_empilhar_resultado_Click;
            // 
            // button_empilhar_valor_final
            // 
            button_empilhar_valor_final.Location = new Point(219, 138);
            button_empilhar_valor_final.Name = "button_empilhar_valor_final";
            button_empilhar_valor_final.Size = new Size(132, 23);
            button_empilhar_valor_final.TabIndex = 18;
            button_empilhar_valor_final.Text = "Empilhar Valor Final";
            button_empilhar_valor_final.UseVisualStyleBackColor = true;
            button_empilhar_valor_final.Click += button_empilhar_valor_final_Click;
            // 
            // button_empilhar_valor_inicial
            // 
            button_empilhar_valor_inicial.Location = new Point(219, 108);
            button_empilhar_valor_inicial.Name = "button_empilhar_valor_inicial";
            button_empilhar_valor_inicial.Size = new Size(132, 24);
            button_empilhar_valor_inicial.TabIndex = 19;
            button_empilhar_valor_inicial.Text = "Empilhar Valor Inicial";
            button_empilhar_valor_inicial.UseVisualStyleBackColor = true;
            button_empilhar_valor_inicial.Click += button_empilhar_valor_inicial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 450);
            Controls.Add(button_empilhar_valor_inicial);
            Controls.Add(button_empilhar_valor_final);
            Controls.Add(button_empilhar_resultado);
            Controls.Add(label_topo_da_pilha);
            Controls.Add(textBox_valor_da_variavel_valor_final);
            Controls.Add(textBox_valor_da_variavel_resultado);
            Controls.Add(textBox_valor_da_variavel_valor_inicial);
            Controls.Add(label_valor_da_variavel_resultado);
            Controls.Add(label_valor_da_variavel_valor_final);
            Controls.Add(label_valor_da_variavel_valor_inicial);
            Controls.Add(label_stack);
            Controls.Add(textBox_valor_final);
            Controls.Add(textBox_resultado);
            Controls.Add(textBox_valor_inicial);
            Controls.Add(label_resultado);
            Controls.Add(label_valor_final);
            Controls.Add(label_valor_inicial);
            Controls.Add(label_thread);
            Controls.Add(label_title);
            Controls.Add(button_calcular);
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_calcular;
        private Label label_title;
        private Label label_thread;
        private Label label_valor_inicial;
        private Label label_valor_final;
        private Label label_resultado;
        private TextBox textBox_valor_inicial;
        private TextBox textBox_resultado;
        private TextBox textBox_valor_final;
        private Label label_stack;
        private TextBox textBox_valor_da_variavel_valor_final;
        private TextBox textBox_valor_da_variavel_resultado;
        private TextBox textBox_valor_da_variavel_valor_inicial;
        private Label label_valor_da_variavel_resultado;
        private Label label_valor_da_variavel_valor_final;
        private Label label_valor_da_variavel_valor_inicial;
        private Label label_topo_da_pilha;
        private Button button_empilhar_resultado;
        private Button button_empilhar_valor_final;
        private Button button_empilhar_valor_inicial;
    }
}
