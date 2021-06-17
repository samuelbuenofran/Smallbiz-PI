
namespace TelasSmallbiz
{
    partial class FormVisualizacoes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarVisualizacoes = new System.Windows.Forms.ProgressBar();
            this.labelText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonVoltar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 156);
            this.panel1.TabIndex = 29;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackgroundImage = global::TelasSmallbiz.Properties.Resources.back;
            this.buttonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVoltar.Image = global::TelasSmallbiz.Properties.Resources.back;
            this.buttonVoltar.Location = new System.Drawing.Point(1016, 57);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(62, 59);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasSmallbiz.Properties.Resources.Logo_sem_fundo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarVisualizacoes
            // 
            this.progressBarVisualizacoes.Location = new System.Drawing.Point(124, 310);
            this.progressBarVisualizacoes.Name = "progressBarVisualizacoes";
            this.progressBarVisualizacoes.Size = new System.Drawing.Size(261, 35);
            this.progressBarVisualizacoes.TabIndex = 30;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(83, 223);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(518, 28);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Quantidade de Visualizações essa semana: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(622, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Número de visualizações";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(64, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(922, 49);
            this.label4.TabIndex = 130;
            this.label4.Text = "                                                            ";
            this.label4.UseWaitCursor = true;
            // 
            // FormVisualizacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1152, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.progressBarVisualizacoes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "FormVisualizacoes";
            this.Text = "Visualizações";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarVisualizacoes;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label4;
    }
}