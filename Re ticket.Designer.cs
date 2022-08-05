namespace joyeria_Olivos
{
    partial class Re_ticket
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
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.Location = new System.Drawing.Point(166, 78);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(130, 34);
            this.textBoxBusqueda.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 72;
            this.label7.Text = "Num. Ticket";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(113, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 43);
            this.button2.TabIndex = 102;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Re_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(340, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBusqueda);
            this.Name = "Re_ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Re_ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}