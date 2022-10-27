namespace Opdracht4
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
            this.lb_titel = new System.Windows.Forms.Label();
            this.lb_tijd = new System.Windows.Forms.Label();
            this.tb_datum = new System.Windows.Forms.DateTimePicker();
            this.tb_titel = new System.Windows.Forms.TextBox();
            this.lb_informatie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_mededeling = new System.Windows.Forms.Label();
            this.cb_tijd = new System.Windows.Forms.CheckBox();
            this.btn_taak_toevoegen = new System.Windows.Forms.Button();
            this.btn_volgende_taak = new System.Windows.Forms.Button();
            this.btn_taak_is_afgewerkt = new System.Windows.Forms.Button();
            this.btn_zet_achteraan = new System.Windows.Forms.Button();
            this.btn_meedelen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.Location = new System.Drawing.Point(71, 41);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(29, 15);
            this.lb_titel.TabIndex = 0;
            this.lb_titel.Text = "Titel";
            // 
            // lb_tijd
            // 
            this.lb_tijd.AutoSize = true;
            this.lb_tijd.Location = new System.Drawing.Point(74, 87);
            this.lb_tijd.Name = "lb_tijd";
            this.lb_tijd.Size = new System.Drawing.Size(26, 15);
            this.lb_tijd.TabIndex = 1;
            this.lb_tijd.Text = "Tijd";
            // 
            // tb_datum
            // 
            this.tb_datum.Location = new System.Drawing.Point(74, 105);
            this.tb_datum.Name = "tb_datum";
            this.tb_datum.Size = new System.Drawing.Size(232, 23);
            this.tb_datum.TabIndex = 14;
            // 
            // tb_titel
            // 
            this.tb_titel.Location = new System.Drawing.Point(74, 59);
            this.tb_titel.Name = "tb_titel";
            this.tb_titel.Size = new System.Drawing.Size(232, 23);
            this.tb_titel.TabIndex = 15;
            // 
            // lb_informatie
            // 
            this.lb_informatie.AutoSize = true;
            this.lb_informatie.Location = new System.Drawing.Point(74, 138);
            this.lb_informatie.Name = "lb_informatie";
            this.lb_informatie.Size = new System.Drawing.Size(62, 15);
            this.lb_informatie.TabIndex = 16;
            this.lb_informatie.Text = "Informatie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 156);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 64);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 64);
            this.textBox2.TabIndex = 20;
            // 
            // lb_mededeling
            // 
            this.lb_mededeling.AutoSize = true;
            this.lb_mededeling.Location = new System.Drawing.Point(322, 138);
            this.lb_mededeling.Name = "lb_mededeling";
            this.lb_mededeling.Size = new System.Drawing.Size(70, 15);
            this.lb_mededeling.TabIndex = 19;
            this.lb_mededeling.Text = "Mededeling";
            // 
            // cb_tijd
            // 
            this.cb_tijd.AutoSize = true;
            this.cb_tijd.Location = new System.Drawing.Point(322, 105);
            this.cb_tijd.Name = "cb_tijd";
            this.cb_tijd.Size = new System.Drawing.Size(45, 19);
            this.cb_tijd.TabIndex = 21;
            this.cb_tijd.Text = "Tijd";
            this.cb_tijd.UseVisualStyleBackColor = true;
            // 
            // btn_taak_toevoegen
            // 
            this.btn_taak_toevoegen.Location = new System.Drawing.Point(74, 226);
            this.btn_taak_toevoegen.Name = "btn_taak_toevoegen";
            this.btn_taak_toevoegen.Size = new System.Drawing.Size(232, 23);
            this.btn_taak_toevoegen.TabIndex = 22;
            this.btn_taak_toevoegen.Text = "taak toevoegen";
            this.btn_taak_toevoegen.UseVisualStyleBackColor = true;
            // 
            // btn_volgende_taak
            // 
            this.btn_volgende_taak.Location = new System.Drawing.Point(74, 255);
            this.btn_volgende_taak.Name = "btn_volgende_taak";
            this.btn_volgende_taak.Size = new System.Drawing.Size(232, 23);
            this.btn_volgende_taak.TabIndex = 23;
            this.btn_volgende_taak.Text = "volgende taak";
            this.btn_volgende_taak.UseVisualStyleBackColor = true;
            // 
            // btn_taak_is_afgewerkt
            // 
            this.btn_taak_is_afgewerkt.Location = new System.Drawing.Point(74, 284);
            this.btn_taak_is_afgewerkt.Name = "btn_taak_is_afgewerkt";
            this.btn_taak_is_afgewerkt.Size = new System.Drawing.Size(232, 23);
            this.btn_taak_is_afgewerkt.TabIndex = 24;
            this.btn_taak_is_afgewerkt.Text = "Taak is afgewerkt";
            this.btn_taak_is_afgewerkt.UseVisualStyleBackColor = true;
            // 
            // btn_zet_achteraan
            // 
            this.btn_zet_achteraan.Location = new System.Drawing.Point(74, 313);
            this.btn_zet_achteraan.Name = "btn_zet_achteraan";
            this.btn_zet_achteraan.Size = new System.Drawing.Size(232, 23);
            this.btn_zet_achteraan.TabIndex = 25;
            this.btn_zet_achteraan.Text = "Zet achteraan";
            this.btn_zet_achteraan.UseVisualStyleBackColor = true;
            // 
            // btn_meedelen
            // 
            this.btn_meedelen.Location = new System.Drawing.Point(322, 226);
            this.btn_meedelen.Name = "btn_meedelen";
            this.btn_meedelen.Size = new System.Drawing.Size(232, 23);
            this.btn_meedelen.TabIndex = 26;
            this.btn_meedelen.Text = "Meedelen in tekstveld";
            this.btn_meedelen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Meedelen in alert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_meedelen);
            this.Controls.Add(this.btn_zet_achteraan);
            this.Controls.Add(this.btn_taak_is_afgewerkt);
            this.Controls.Add(this.btn_volgende_taak);
            this.Controls.Add(this.btn_taak_toevoegen);
            this.Controls.Add(this.cb_tijd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_mededeling);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_informatie);
            this.Controls.Add(this.tb_titel);
            this.Controls.Add(this.tb_datum);
            this.Controls.Add(this.lb_tijd);
            this.Controls.Add(this.lb_titel);
            this.Name = "Form1";
            this.Text = "TeDoen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_titel;
        private Label lb_tijd;
        private DateTimePicker tb_datum;
        private TextBox tb_titel;
        private Label lb_informatie;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lb_mededeling;
        private CheckBox cb_tijd;
        private Button btn_taak_toevoegen;
        private Button btn_volgende_taak;
        private Button btn_taak_is_afgewerkt;
        private Button btn_zet_achteraan;
        private Button btn_meedelen;
        private Button button1;
    }
}