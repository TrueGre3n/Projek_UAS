
namespace _160421029_Nico_Victorio
{
    partial class FormTambahPosition
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
            this.tb_Keterangan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_IdPosition = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_NamaPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Keterangan
            // 
            this.tb_Keterangan.Location = new System.Drawing.Point(183, 138);
            this.tb_Keterangan.Name = "tb_Keterangan";
            this.tb_Keterangan.Size = new System.Drawing.Size(193, 22);
            this.tb_Keterangan.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Keterangan";
            // 
            // tb_IdPosition
            // 
            this.tb_IdPosition.Location = new System.Drawing.Point(183, 36);
            this.tb_IdPosition.Name = "tb_IdPosition";
            this.tb_IdPosition.Size = new System.Drawing.Size(193, 22);
            this.tb_IdPosition.TabIndex = 45;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(288, 191);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 34);
            this.btn_Exit.TabIndex = 47;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(47, 191);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 39);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // tb_NamaPosition
            // 
            this.tb_NamaPosition.Location = new System.Drawing.Point(183, 86);
            this.tb_NamaPosition.Name = "tb_NamaPosition";
            this.tb_NamaPosition.Size = new System.Drawing.Size(193, 22);
            this.tb_NamaPosition.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nama Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id Position";
            // 
            // FormTambahPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.tb_Keterangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_IdPosition);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_NamaPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTambahPosition";
            this.Text = "FormTambahPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Keterangan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_IdPosition;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_NamaPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}