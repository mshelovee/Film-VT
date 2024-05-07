namespace Fim_VT_96
{
    partial class TumFilmlerForm
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
            this.dgwTumFilmler = new System.Windows.Forms.DataGridView();
            this.cbOdul = new System.Windows.Forms.CheckBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.rbFilmAd = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTumFilmler
            // 
            this.dgwTumFilmler.AllowUserToAddRows = false;
            this.dgwTumFilmler.AllowUserToDeleteRows = false;
            this.dgwTumFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTumFilmler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwTumFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTumFilmler.Location = new System.Drawing.Point(21, 315);
            this.dgwTumFilmler.Name = "dgwTumFilmler";
            this.dgwTumFilmler.ReadOnly = true;
            this.dgwTumFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTumFilmler.Size = new System.Drawing.Size(739, 258);
            this.dgwTumFilmler.TabIndex = 41;
            this.dgwTumFilmler.SelectionChanged += new System.EventHandler(this.dgwTumFilmler_SelectionChanged);
            // 
            // cbOdul
            // 
            this.cbOdul.AutoSize = true;
            this.cbOdul.Location = new System.Drawing.Point(159, 237);
            this.cbOdul.Name = "cbOdul";
            this.cbOdul.Size = new System.Drawing.Size(68, 17);
            this.cbOdul.TabIndex = 56;
            this.cbOdul.Text = "Ödül Aldı";
            this.cbOdul.UseVisualStyleBackColor = true;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(92, 211);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(135, 20);
            this.txtPuan.TabIndex = 55;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(92, 170);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(135, 20);
            this.txtSure.TabIndex = 53;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(92, 131);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(135, 21);
            this.cmbTur.TabIndex = 52;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(92, 58);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(135, 20);
            this.txtYonetmen.TabIndex = 50;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 20);
            this.txtAd.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(46, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "İMDB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(255, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Poster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Yönetmen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ad";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(92, 257);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(135, 20);
            this.txtArama.TabIndex = 57;
            // 
            // rbFilmAd
            // 
            this.rbFilmAd.AutoSize = true;
            this.rbFilmAd.Location = new System.Drawing.Point(27, 257);
            this.rbFilmAd.Name = "rbFilmAd";
            this.rbFilmAd.Size = new System.Drawing.Size(59, 17);
            this.rbFilmAd.TabIndex = 58;
            this.rbFilmAd.TabStop = true;
            this.rbFilmAd.Text = "Film Ad";
            this.rbFilmAd.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(683, 69);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(77, 65);
            this.btnAra.TabIndex = 61;
            this.btnAra.Text = "🔍︎";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(683, 211);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(77, 65);
            this.btnGuncelle.TabIndex = 60;
            this.btnGuncelle.Text = "♻️";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(683, 140);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 65);
            this.btnSil.TabIndex = 59;
            this.btnSil.Text = "🗑";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(92, 95);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(135, 20);
            this.txtYil.TabIndex = 63;
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbResim.Location = new System.Drawing.Point(258, 46);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(148, 231);
            this.pbResim.TabIndex = 64;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // TumFilmlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(781, 585);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.rbFilmAd);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cbOdul);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwTumFilmler);
            this.Name = "TumFilmlerForm";
            this.Text = "TumFilmlerForm";
            this.Load += new System.EventHandler(this.TumFilmlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTumFilmler;
        private System.Windows.Forms.CheckBox cbOdul;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.RadioButton rbFilmAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.PictureBox pbResim;
    }
}