namespace JogaDaVelha
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
            groupBox1 = new GroupBox();
            BtnReiniciar = new Button();
            BtnIniciar = new Button();
            LblJogadorO = new Label();
            LblJogadorX = new Label();
            BtnO = new Button();
            BtnX = new Button();
            groupBox2 = new GroupBox();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnReiniciar);
            groupBox1.Controls.Add(BtnIniciar);
            groupBox1.Controls.Add(LblJogadorO);
            groupBox1.Controls.Add(LblJogadorX);
            groupBox1.Controls.Add(BtnO);
            groupBox1.Controls.Add(BtnX);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 472);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // BtnReiniciar
            // 
            BtnReiniciar.BackColor = Color.DarkOrange;
            BtnReiniciar.BackgroundImageLayout = ImageLayout.Center;
            BtnReiniciar.Enabled = false;
            BtnReiniciar.Font = new Font("Stencil", 20F, FontStyle.Bold);
            BtnReiniciar.ForeColor = Color.Black;
            BtnReiniciar.Location = new Point(23, 394);
            BtnReiniciar.Name = "BtnReiniciar";
            BtnReiniciar.Size = new Size(380, 53);
            BtnReiniciar.TabIndex = 5;
            BtnReiniciar.Text = "REINICIAR";
            BtnReiniciar.UseVisualStyleBackColor = false;
            BtnReiniciar.Click += BtnReiniciar_Click;
            // 
            // BtnIniciar
            // 
            BtnIniciar.BackColor = Color.DodgerBlue;
            BtnIniciar.Enabled = false;
            BtnIniciar.Font = new Font("Stencil", 30F, FontStyle.Bold);
            BtnIniciar.ForeColor = Color.Black;
            BtnIniciar.Location = new Point(23, 266);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(380, 108);
            BtnIniciar.TabIndex = 4;
            BtnIniciar.Text = "INICIAR";
            BtnIniciar.UseVisualStyleBackColor = false;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // LblJogadorO
            // 
            LblJogadorO.AutoSize = true;
            LblJogadorO.BackColor = Color.Black;
            LblJogadorO.ForeColor = Color.White;
            LblJogadorO.Location = new Point(244, 205);
            LblJogadorO.Name = "LblJogadorO";
            LblJogadorO.Size = new Size(119, 25);
            LblJogadorO.TabIndex = 3;
            LblJogadorO.Text = "JOGADOR 02";
            // 
            // LblJogadorX
            // 
            LblJogadorX.AutoSize = true;
            LblJogadorX.BackColor = Color.Black;
            LblJogadorX.ForeColor = Color.White;
            LblJogadorX.Location = new Point(59, 206);
            LblJogadorX.Name = "LblJogadorX";
            LblJogadorX.Size = new Size(119, 25);
            LblJogadorX.TabIndex = 2;
            LblJogadorX.Text = "JOGADOR 01";
            // 
            // BtnO
            // 
            BtnO.BackColor = Color.Red;
            BtnO.BackgroundImageLayout = ImageLayout.Center;
            BtnO.Font = new Font("Stencil", 60F, FontStyle.Bold);
            BtnO.ForeColor = Color.Black;
            BtnO.Location = new Point(231, 75);
            BtnO.Name = "BtnO";
            BtnO.Size = new Size(152, 128);
            BtnO.TabIndex = 1;
            BtnO.Text = "O";
            BtnO.UseVisualStyleBackColor = false;
            BtnO.Click += BtnO_Click;
            // 
            // BtnX
            // 
            BtnX.BackColor = Color.Lime;
            BtnX.BackgroundImageLayout = ImageLayout.Center;
            BtnX.Font = new Font("Stencil", 60F, FontStyle.Bold);
            BtnX.ForeColor = Color.Black;
            BtnX.Location = new Point(44, 76);
            BtnX.Name = "BtnX";
            BtnX.Size = new Size(152, 127);
            BtnX.TabIndex = 0;
            BtnX.Text = "X";
            BtnX.UseVisualStyleBackColor = false;
            BtnX.Click += BtnX_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn9);
            groupBox2.Controls.Add(Btn8);
            groupBox2.Controls.Add(Btn7);
            groupBox2.Controls.Add(Btn6);
            groupBox2.Controls.Add(Btn5);
            groupBox2.Controls.Add(Btn4);
            groupBox2.Controls.Add(Btn3);
            groupBox2.Controls.Add(Btn2);
            groupBox2.Controls.Add(Btn1);
            groupBox2.Location = new Point(457, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(684, 558);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.Black;
            Btn9.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(458, 361);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(199, 147);
            Btn9.TabIndex = 13;
            Btn9.Text = "X";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += Btn9_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.Black;
            Btn8.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(253, 361);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(199, 147);
            Btn8.TabIndex = 12;
            Btn8.Text = "O";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += Btn8_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.Black;
            Btn7.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(48, 361);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(199, 147);
            Btn7.TabIndex = 11;
            Btn7.Text = "X";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += Btn7_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.Black;
            Btn6.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(458, 208);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(199, 147);
            Btn6.TabIndex = 10;
            Btn6.Text = "O";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += Btn6_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.Black;
            Btn5.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(253, 208);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(199, 147);
            Btn5.TabIndex = 9;
            Btn5.Text = "X";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += Btn5_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.Black;
            Btn4.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(48, 208);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(199, 147);
            Btn4.TabIndex = 8;
            Btn4.Text = "O";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += Btn4_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.Black;
            Btn3.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(458, 55);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(199, 147);
            Btn3.TabIndex = 7;
            Btn3.Text = "X";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += Btn3_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.Black;
            Btn2.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(253, 55);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(199, 147);
            Btn2.TabIndex = 6;
            Btn2.Text = "O";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += Btn2_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.Black;
            Btn1.Font = new Font("Stencil", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(48, 55);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(199, 147);
            Btn1.TabIndex = 5;
            Btn1.Text = "X";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += Btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1153, 582);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnIniciar;
        private Label LblJogadorO;
        private Label LblJogadorX;
        private GroupBox groupBox2;
        private Button Btn1;
        private Button Btn3;
        private Button Btn2;
        private Button BtnO;
        private Button BtnX;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnReiniciar;
    }
}
