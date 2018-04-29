namespace My7zip
{
    partial class My7zip
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Geral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Descomprimir = new System.Windows.Forms.Button();
            this.bt_Diretorio = new System.Windows.Forms.Button();
            this.bt_Ficheiro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CaminhoDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Ficheiro = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_SairComp = new System.Windows.Forms.Button();
            this.bt_Comprimir = new System.Windows.Forms.Button();
            this.bt_DirComp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FicheiroComp = new System.Windows.Forms.TextBox();
            this.tb_DirComp = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tab_Geral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Geral
            // 
            this.tab_Geral.Controls.Add(this.tabPage1);
            this.tab_Geral.Controls.Add(this.tabPage2);
            this.tab_Geral.Location = new System.Drawing.Point(3, 1);
            this.tab_Geral.Name = "tab_Geral";
            this.tab_Geral.SelectedIndex = 0;
            this.tab_Geral.Size = new System.Drawing.Size(508, 371);
            this.tab_Geral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_Sair);
            this.tabPage1.Controls.Add(this.bt_Descomprimir);
            this.tabPage1.Controls.Add(this.bt_Diretorio);
            this.tabPage1.Controls.Add(this.bt_Ficheiro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_CaminhoDir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_Ficheiro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descomprimir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(152, 227);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(75, 23);
            this.bt_Sair.TabIndex = 7;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Descomprimir
            // 
            this.bt_Descomprimir.Location = new System.Drawing.Point(21, 228);
            this.bt_Descomprimir.Name = "bt_Descomprimir";
            this.bt_Descomprimir.Size = new System.Drawing.Size(88, 23);
            this.bt_Descomprimir.TabIndex = 6;
            this.bt_Descomprimir.Text = "Descomprimir";
            this.bt_Descomprimir.UseVisualStyleBackColor = true;
            this.bt_Descomprimir.Click += new System.EventHandler(this.bt_Descomprimir_Click);
            // 
            // bt_Diretorio
            // 
            this.bt_Diretorio.Location = new System.Drawing.Point(398, 119);
            this.bt_Diretorio.Name = "bt_Diretorio";
            this.bt_Diretorio.Size = new System.Drawing.Size(75, 23);
            this.bt_Diretorio.TabIndex = 5;
            this.bt_Diretorio.Text = "Procurar";
            this.bt_Diretorio.UseVisualStyleBackColor = true;
            this.bt_Diretorio.Click += new System.EventHandler(this.bt_Diretorio_Click);
            // 
            // bt_Ficheiro
            // 
            this.bt_Ficheiro.Location = new System.Drawing.Point(398, 69);
            this.bt_Ficheiro.Name = "bt_Ficheiro";
            this.bt_Ficheiro.Size = new System.Drawing.Size(75, 23);
            this.bt_Ficheiro.TabIndex = 4;
            this.bt_Ficheiro.Text = "Procurar";
            this.bt_Ficheiro.UseVisualStyleBackColor = true;
            this.bt_Ficheiro.Click += new System.EventHandler(this.bt_Ficheiro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ficheiro";
            // 
            // tb_CaminhoDir
            // 
            this.tb_CaminhoDir.Location = new System.Drawing.Point(21, 119);
            this.tb_CaminhoDir.Name = "tb_CaminhoDir";
            this.tb_CaminhoDir.Size = new System.Drawing.Size(345, 20);
            this.tb_CaminhoDir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diretório de saída";
            // 
            // tb_Ficheiro
            // 
            this.tb_Ficheiro.Location = new System.Drawing.Point(21, 69);
            this.tb_Ficheiro.Name = "tb_Ficheiro";
            this.tb_Ficheiro.Size = new System.Drawing.Size(345, 20);
            this.tb_Ficheiro.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_SairComp);
            this.tabPage2.Controls.Add(this.bt_Comprimir);
            this.tabPage2.Controls.Add(this.bt_DirComp);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_FicheiroComp);
            this.tabPage2.Controls.Add(this.tb_DirComp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comprimir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_SairComp
            // 
            this.bt_SairComp.Location = new System.Drawing.Point(152, 227);
            this.bt_SairComp.Name = "bt_SairComp";
            this.bt_SairComp.Size = new System.Drawing.Size(75, 23);
            this.bt_SairComp.TabIndex = 7;
            this.bt_SairComp.Text = "Sair";
            this.bt_SairComp.UseVisualStyleBackColor = true;
            this.bt_SairComp.Click += new System.EventHandler(this.bt_SairComp_Click);
            // 
            // bt_Comprimir
            // 
            this.bt_Comprimir.Location = new System.Drawing.Point(21, 228);
            this.bt_Comprimir.Name = "bt_Comprimir";
            this.bt_Comprimir.Size = new System.Drawing.Size(75, 23);
            this.bt_Comprimir.TabIndex = 6;
            this.bt_Comprimir.Text = "Comprimir";
            this.bt_Comprimir.UseVisualStyleBackColor = true;
            this.bt_Comprimir.Click += new System.EventHandler(this.bt_Comprimir_Click);
            // 
            // bt_DirComp
            // 
            this.bt_DirComp.Location = new System.Drawing.Point(398, 69);
            this.bt_DirComp.Name = "bt_DirComp";
            this.bt_DirComp.Size = new System.Drawing.Size(75, 23);
            this.bt_DirComp.TabIndex = 4;
            this.bt_DirComp.Text = "Procurar";
            this.bt_DirComp.UseVisualStyleBackColor = true;
            this.bt_DirComp.Click += new System.EventHandler(this.bt_DirComp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do arquivo de saída (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diretório a comprimir";
            // 
            // tb_FicheiroComp
            // 
            this.tb_FicheiroComp.Location = new System.Drawing.Point(21, 119);
            this.tb_FicheiroComp.Name = "tb_FicheiroComp";
            this.tb_FicheiroComp.Size = new System.Drawing.Size(345, 20);
            this.tb_FicheiroComp.TabIndex = 1;
            // 
            // tb_DirComp
            // 
            this.tb_DirComp.Location = new System.Drawing.Point(21, 69);
            this.tb_DirComp.Name = "tb_DirComp";
            this.tb_DirComp.Size = new System.Drawing.Size(345, 20);
            this.tb_DirComp.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.7z";
            // 
            // My7zip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 369);
            this.Controls.Add(this.tab_Geral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "My7zip";
            this.Text = "My7Zip";
            this.Load += new System.EventHandler(this.My7z_Load);
            this.tab_Geral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Geral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Descomprimir;
        private System.Windows.Forms.Button bt_Diretorio;
        private System.Windows.Forms.Button bt_Ficheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CaminhoDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Ficheiro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_SairComp;
        private System.Windows.Forms.Button bt_Comprimir;
        private System.Windows.Forms.Button bt_DirComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FicheiroComp;
        private System.Windows.Forms.TextBox tb_DirComp;
    }
}

