namespace TelasSmallbiz
{
    partial class FormTelaDeLogin
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
            this.DB_VDP_CRED_LOGIN = new TelasSmallbiz.DB_VITRINEDEPRODUTOSDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.DB_VDP_CRED_LOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // DB_VDP_CRED_LOGIN
            // 
            this.DB_VDP_CRED_LOGIN.DataSetName = "DB_VDP_CRED_LOGIN";
            this.DB_VDP_CRED_LOGIN.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.DB_VDP_CRED_LOGIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormTelaDeLogin";
            this.Text = "FormTelaDeLogin";
            ((System.ComponentModel.ISupportInitialize)(this.DB_VDP_CRED_LOGIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DB_VITRINEDEPRODUTOSDataSet DB_VDP_CRED_LOGIN;
    }
}