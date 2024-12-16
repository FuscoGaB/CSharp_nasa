namespace Nasa_conto_rovescia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_houston = new Button();
            button_cape = new Button();
            labelHouston = new Label();
            labelCape = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // button_houston
            // 
            button_houston.Location = new Point(177, 176);
            button_houston.Name = "button_houston";
            button_houston.Size = new Size(94, 29);
            button_houston.TabIndex = 0;
            button_houston.Text = "houston";
            button_houston.UseVisualStyleBackColor = true;
            button_houston.Click += button_houston_Click;
            // 
            // button_cape
            // 
            button_cape.Location = new Point(362, 176);
            button_cape.Name = "button_cape";
            button_cape.Size = new Size(94, 29);
            button_cape.TabIndex = 1;
            button_cape.Text = "cape";
            button_cape.UseVisualStyleBackColor = true;
            button_cape.Click += button_cape_Click;
            // 
            // labelHouston
            // 
            labelHouston.AutoSize = true;
            labelHouston.Location = new Point(198, 228);
            labelHouston.Name = "labelHouston";
            labelHouston.Size = new Size(50, 20);
            labelHouston.TabIndex = 2;
            labelHouston.Text = "label1";
            // 
            // labelCape
            // 
            labelCape.AutoSize = true;
            labelCape.Location = new Point(384, 228);
            labelCape.Name = "labelCape";
            labelCape.Size = new Size(50, 20);
            labelCape.TabIndex = 3;
            labelCape.Text = "label2";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(284, 134);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatus);
            Controls.Add(labelCape);
            Controls.Add(labelHouston);
            Controls.Add(button_cape);
            Controls.Add(button_houston);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_houston;
        private Button button_cape;
        private Label labelHouston;
        private Label labelCape;
        private Label labelStatus;
    }
}
