﻿namespace view
{
    partial class frm_principal
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
            this.cbx_sexo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_sexo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownWidth = 274;
            this.cbx_sexo.Location = new System.Drawing.Point(199, 116);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.cbx_sexo.Size = new System.Drawing.Size(274, 21);
            this.cbx_sexo.TabIndex = 0;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_sexo);
            this.Name = "frm_principal";
            this.Text = "frm_principal";
            ((System.ComponentModel.ISupportInitialize)(this.cbx_sexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_sexo;
    }
}