namespace Ejercicios___Unidad_2
{
    partial class Form14
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            buttonIniciar = new Button();
            buttonDetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(41, 149);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(733, 29);
            progressBar1.TabIndex = 0;
            // 
            // buttonIniciar
            // 
            buttonIniciar.Location = new Point(213, 266);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(94, 29);
            buttonIniciar.TabIndex = 1;
            buttonIniciar.Text = "Iniciar";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // buttonDetener
            // 
            buttonDetener.Location = new Point(472, 266);
            buttonDetener.Name = "buttonDetener";
            buttonDetener.Size = new Size(94, 29);
            buttonDetener.TabIndex = 2;
            buttonDetener.Text = "Detener";
            buttonDetener.UseVisualStyleBackColor = true;
            buttonDetener.Click += buttonDetener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDetener);
            Controls.Add(buttonIniciar);
            Controls.Add(progressBar1);
            Name = "Form14";
            Text = "Form14";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button buttonIniciar;
        private Button buttonDetener;
        private System.Windows.Forms.Timer timer1;
    }
}