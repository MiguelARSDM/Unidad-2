namespace Ejercicios___Unidad_2
{
    partial class Form15
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
            tabControl1 = new TabControl();
            pagina1 = new TabPage();
            pagina2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            pagina1.SuspendLayout();
            pagina2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pagina1);
            tabControl1.Controls.Add(pagina2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 438);
            tabControl1.TabIndex = 0;
            // 
            // pagina1
            // 
            pagina1.Controls.Add(label1);
            pagina1.Location = new Point(4, 29);
            pagina1.Name = "pagina1";
            pagina1.Padding = new Padding(3);
            pagina1.Size = new Size(780, 405);
            pagina1.TabIndex = 0;
            pagina1.Text = "pagina 1";
            pagina1.UseVisualStyleBackColor = true;
            // 
            // pagina2
            // 
            pagina2.Controls.Add(label2);
            pagina2.Location = new Point(4, 29);
            pagina2.Name = "pagina2";
            pagina2.Padding = new Padding(3);
            pagina2.Size = new Size(780, 405);
            pagina2.TabIndex = 1;
            pagina2.Text = "Pagina 2";
            pagina2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 151);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 0;
            label1.Text = "MIGUEL ANGEL RAMIREZ SANCHEZ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 192);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "MT-2024-00210";
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form15";
            Text = "Form15";
            tabControl1.ResumeLayout(false);
            pagina1.ResumeLayout(false);
            pagina1.PerformLayout();
            pagina2.ResumeLayout(false);
            pagina2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pagina1;
        private TabPage pagina2;
        private Label label1;
        private Label label2;
    }
}