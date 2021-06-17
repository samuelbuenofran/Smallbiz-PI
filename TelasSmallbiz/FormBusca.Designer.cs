
namespace TelasSmallbiz
{
    partial class FormBusca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusca));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.tBPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVITRINEDEPRODUTOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_VITRINEDEPRODUTOSDataSet = new TelasSmallbiz.DB_VITRINEDEPRODUTOSDataSet();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.mostrarPesquisa = new System.Windows.Forms.DataGridView();
            this.tB_PRODUTOTableAdapter = new TelasSmallbiz.DB_VITRINEDEPRODUTOSDataSetTableAdapters.TB_PRODUTOTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bancoDeDados = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVITRINEDEPRODUTOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VITRINEDEPRODUTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarPesquisa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBoxBusca);
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Location = new System.Drawing.Point(112, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 138);
            this.panel2.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::TelasSmallbiz.Properties.Resources.lupa_removebg_preview;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Location = new System.Drawing.Point(425, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 24);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TelasSmallbiz.Properties.Resources.Logo_sem_fundo;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(302, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 19);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "CEP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxBusca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBPRODUTOBindingSource, "ID_PRODUTO", true));
            this.textBoxBusca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusca.Location = new System.Drawing.Point(302, 76);
            this.textBoxBusca.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(331, 26);
            this.textBoxBusca.TabIndex = 5;
            this.textBoxBusca.Text = "Buscar Produto, Marca ou Empresa..";
            this.textBoxBusca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBusca.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            // 
            // tBPRODUTOBindingSource
            // 
            this.tBPRODUTOBindingSource.DataMember = "TB_PRODUTO";
            this.tBPRODUTOBindingSource.DataSource = this.dBVITRINEDEPRODUTOSDataSetBindingSource;
            // 
            // dBVITRINEDEPRODUTOSDataSetBindingSource
            // 
            this.dBVITRINEDEPRODUTOSDataSetBindingSource.DataSource = this.dB_VITRINEDEPRODUTOSDataSet;
            this.dBVITRINEDEPRODUTOSDataSetBindingSource.Position = 0;
            // 
            // dB_VITRINEDEPRODUTOSDataSet
            // 
            this.dB_VITRINEDEPRODUTOSDataSet.DataSetName = "DB_VITRINEDEPRODUTOSDataSet";
            this.dB_VITRINEDEPRODUTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::TelasSmallbiz.Properties.Resources.lupa_removebg_preview;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBuscar.Location = new System.Drawing.Point(629, 76);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(26, 24);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // mostrarPesquisa
            // 
            this.mostrarPesquisa.AllowUserToAddRows = false;
            this.mostrarPesquisa.AllowUserToDeleteRows = false;
            this.mostrarPesquisa.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.mostrarPesquisa.ColumnHeadersHeight = 32;
            this.mostrarPesquisa.ColumnHeadersVisible = false;
            this.mostrarPesquisa.Enabled = false;
            this.mostrarPesquisa.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mostrarPesquisa.Location = new System.Drawing.Point(112, 228);
            this.mostrarPesquisa.Name = "mostrarPesquisa";
            this.mostrarPesquisa.ReadOnly = true;
            this.mostrarPesquisa.RowHeadersVisible = false;
            this.mostrarPesquisa.Size = new System.Drawing.Size(681, 237);
            this.mostrarPesquisa.TabIndex = 34;
            this.mostrarPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mostrarPesquisa_CellContentClick);
            // 
            // tB_PRODUTOTableAdapter
            // 
            this.tB_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "Mostrar Código de Locais";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::TelasSmallbiz.Properties.Resources.scratch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(69, 586);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 85);
            this.toolStripButton1.Text = "Voltar";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasSmallbiz.Properties.Resources.promotions_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(854, 228);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "NOME DO PRODUTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(258, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "VALOR UNITÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(403, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(499, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(595, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "QUANTIDADE DISPONÍVEL";
            // 
            // FormBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(982, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mostrarPesquisa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBusca";
            this.Text = "Resultados para a busca";
            this.Load += new System.EventHandler(this.FormBusca_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVITRINEDEPRODUTOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_VITRINEDEPRODUTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarPesquisa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bancoDeDados;
        private System.Windows.Forms.BindingSource dBVITRINEDEPRODUTOSDataSetBindingSource;
        private DB_VITRINEDEPRODUTOSDataSet dB_VITRINEDEPRODUTOSDataSet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView mostrarPesquisa;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource tBPRODUTOBindingSource;
        private DB_VITRINEDEPRODUTOSDataSetTableAdapters.TB_PRODUTOTableAdapter tB_PRODUTOTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}