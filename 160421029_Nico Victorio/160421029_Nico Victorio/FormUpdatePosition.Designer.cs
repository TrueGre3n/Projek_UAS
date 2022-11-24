
namespace _160421029_Nico_Victorio
{
    partial class FormUpdatePosition
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
            this.tb_Keterangan.Location = new System.Drawing.Point(172, 133);
            this.tb_Keterangan.Name = "tb_Keterangan";
            this.tb_Keterangan.Size = new System.Drawing.Size(193, 22);
            this.tb_Keterangan.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Keterangan";
            // 
            // tb_IdPosition
            // 
            this.tb_IdPosition.Location = new System.Drawing.Point(172, 31);
            this.tb_IdPosition.Name = "tb_IdPosition";
            this.tb_IdPosition.Size = new System.Drawing.Size(193, 22);
            this.tb_IdPosition.TabIndex = 53;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(277, 186);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 34);
            this.btn_Exit.TabIndex = 55;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(36, 186);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 39);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_NamaPosition
            // 
            this.tb_NamaPosition.Location = new System.Drawing.Point(172, 81);
            this.tb_NamaPosition.Name = "tb_NamaPosition";
            this.tb_NamaPosition.Size = new System.Drawing.Size(193, 22);
            this.tb_NamaPosition.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nama Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Id Position";
            // 
            // FormUpdatePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 266);
            this.Controls.Add(this.tb_Keterangan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_IdPosition);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_NamaPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePosition";
            this.Text = "FormUpdatePosition";
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