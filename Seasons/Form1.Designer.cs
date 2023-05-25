namespace Seasons
{
    partial class Seasons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seasons));
            _btnSummer = new Button();
            _btnSpring = new Button();
            _btnAutumn = new Button();
            _btnWinter = new Button();
            SuspendLayout();
            // 
            // _btnSummer
            // 
            _btnSummer.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            _btnSummer.ForeColor = Color.FromArgb(255, 128, 0);
            _btnSummer.Location = new Point(307, 485);
            _btnSummer.Name = "_btnSummer";
            _btnSummer.Size = new Size(133, 50);
            _btnSummer.TabIndex = 0;
            _btnSummer.Text = "Лето";
            _btnSummer.UseVisualStyleBackColor = true;
            _btnSummer.Click += _btnSummer_Click;
            // 
            // _btnSpring
            // 
            _btnSpring.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            _btnSpring.ForeColor = Color.FromArgb(0, 192, 0);
            _btnSpring.Location = new Point(32, 485);
            _btnSpring.Name = "_btnSpring";
            _btnSpring.Size = new Size(133, 50);
            _btnSpring.TabIndex = 1;
            _btnSpring.Text = "Весна";
            _btnSpring.UseVisualStyleBackColor = true;
            _btnSpring.Click += _btnSpring_Click;
            // 
            // _btnAutumn
            // 
            _btnAutumn.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            _btnAutumn.ForeColor = Color.FromArgb(128, 64, 0);
            _btnAutumn.Location = new Point(557, 485);
            _btnAutumn.Name = "_btnAutumn";
            _btnAutumn.Size = new Size(133, 50);
            _btnAutumn.TabIndex = 2;
            _btnAutumn.Text = "Осень";
            _btnAutumn.UseVisualStyleBackColor = true;
            _btnAutumn.Click += _btnAutumn_Click;
            // 
            // _btnWinter
            // 
            _btnWinter.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            _btnWinter.ForeColor = Color.DodgerBlue;
            _btnWinter.Location = new Point(831, 485);
            _btnWinter.Name = "_btnWinter";
            _btnWinter.Size = new Size(133, 50);
            _btnWinter.TabIndex = 3;
            _btnWinter.Text = "Зима";
            _btnWinter.UseVisualStyleBackColor = true;
            _btnWinter.Click += _btnWinter_Click;
            // 
            // Seasons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(998, 620);
            Controls.Add(_btnWinter);
            Controls.Add(_btnAutumn);
            Controls.Add(_btnSpring);
            Controls.Add(_btnSummer);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Seasons";
            Text = "Времена года";
            ResumeLayout(false);
        }

        #endregion

        private Button _btnSummer;
        private Button _btnSpring;
        private Button _btnAutumn;
        private Button _btnWinter;
    }
}