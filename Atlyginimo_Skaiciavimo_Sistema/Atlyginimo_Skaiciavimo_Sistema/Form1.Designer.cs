namespace Atlyginimo_Skaiciavimo_Sistema
{
    partial class Form1
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
            this.AtlyginimasTXT = new System.Windows.Forms.TextBox();
            this.AtlAntPopIrank = new System.Windows.Forms.TabControl();
            this.tbpAntPop = new System.Windows.Forms.TabPage();
            this.Isvedimas = new System.Windows.Forms.RichTextBox();
            this.tbpIrank = new System.Windows.Forms.TabPage();
            this.Isvedimas2 = new System.Windows.Forms.RichTextBox();
            this.rdbPaskSist = new System.Windows.Forms.RadioButton();
            this.rdbPats = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkKaupPens = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPensProc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNPDnur = new System.Windows.Forms.TextBox();
            this.txtAtlyginimoStatusas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.apvalusMygtukasButton1 = new Atlyginimo_Skaiciavimo_Sistema.ApvalusMygtukasButton();
            this.AtlAntPopIrank.SuspendLayout();
            this.tbpAntPop.SuspendLayout();
            this.tbpIrank.SuspendLayout();
            this.SuspendLayout();
            // 
            // AtlyginimasTXT
            // 
            this.AtlyginimasTXT.Location = new System.Drawing.Point(232, 116);
            this.AtlyginimasTXT.Name = "AtlyginimasTXT";
            this.AtlyginimasTXT.Size = new System.Drawing.Size(150, 20);
            this.AtlyginimasTXT.TabIndex = 0;
            this.AtlyginimasTXT.TextChanged += new System.EventHandler(this.AtlyginimasTXT_TextChanged);
            this.AtlyginimasTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtlyginimasTXT_KeyPress);
            // 
            // AtlAntPopIrank
            // 
            this.AtlAntPopIrank.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.AtlAntPopIrank.Controls.Add(this.tbpAntPop);
            this.AtlAntPopIrank.Controls.Add(this.tbpIrank);
            this.AtlAntPopIrank.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.AtlAntPopIrank.Location = new System.Drawing.Point(228, 142);
            this.AtlAntPopIrank.Name = "AtlAntPopIrank";
            this.AtlAntPopIrank.SelectedIndex = 0;
            this.AtlAntPopIrank.Size = new System.Drawing.Size(158, 306);
            this.AtlAntPopIrank.TabIndex = 1;
            this.AtlAntPopIrank.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.AtlAntPopIrank_DrawItem);
            this.AtlAntPopIrank.SelectedIndexChanged += new System.EventHandler(this.AtlAntPopIrank_SelectedIndexChanged);
            // 
            // tbpAntPop
            // 
            this.tbpAntPop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpAntPop.Controls.Add(this.Isvedimas);
            this.tbpAntPop.Location = new System.Drawing.Point(4, 25);
            this.tbpAntPop.Name = "tbpAntPop";
            this.tbpAntPop.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAntPop.Size = new System.Drawing.Size(150, 277);
            this.tbpAntPop.TabIndex = 0;
            this.tbpAntPop.Text = "\"Ant popieriaus\"";
            // 
            // Isvedimas
            // 
            this.Isvedimas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Isvedimas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Isvedimas.Location = new System.Drawing.Point(6, 16);
            this.Isvedimas.Name = "Isvedimas";
            this.Isvedimas.ReadOnly = true;
            this.Isvedimas.Size = new System.Drawing.Size(100, 247);
            this.Isvedimas.TabIndex = 0;
            this.Isvedimas.Text = "";
            this.Isvedimas.Enter += new System.EventHandler(this.Isvedimas_Enter);
            this.Isvedimas.Leave += new System.EventHandler(this.Isvedimas_Leave);
            // 
            // tbpIrank
            // 
            this.tbpIrank.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpIrank.Controls.Add(this.Isvedimas2);
            this.tbpIrank.Location = new System.Drawing.Point(4, 25);
            this.tbpIrank.Name = "tbpIrank";
            this.tbpIrank.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIrank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbpIrank.Size = new System.Drawing.Size(150, 277);
            this.tbpIrank.TabIndex = 1;
            this.tbpIrank.Text = "\"Į rankas\"";
            // 
            // Isvedimas2
            // 
            this.Isvedimas2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Isvedimas2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Isvedimas2.Location = new System.Drawing.Point(6, 16);
            this.Isvedimas2.Name = "Isvedimas2";
            this.Isvedimas2.ReadOnly = true;
            this.Isvedimas2.Size = new System.Drawing.Size(100, 247);
            this.Isvedimas2.TabIndex = 0;
            this.Isvedimas2.Text = "";
            // 
            // rdbPaskSist
            // 
            this.rdbPaskSist.AutoSize = true;
            this.rdbPaskSist.Checked = true;
            this.rdbPaskSist.Location = new System.Drawing.Point(435, 142);
            this.rdbPaskSist.Name = "rdbPaskSist";
            this.rdbPaskSist.Size = new System.Drawing.Size(119, 17);
            this.rdbPaskSist.TabIndex = 2;
            this.rdbPaskSist.TabStop = true;
            this.rdbPaskSist.Text = "paskaičiuos sistema";
            this.rdbPaskSist.UseVisualStyleBackColor = true;
            this.rdbPaskSist.Click += new System.EventHandler(this.NPDSistNur);
            // 
            // rdbPats
            // 
            this.rdbPats.AutoSize = true;
            this.rdbPats.Location = new System.Drawing.Point(435, 165);
            this.rdbPats.Name = "rdbPats";
            this.rdbPats.Size = new System.Drawing.Size(93, 17);
            this.rdbPats.TabIndex = 3;
            this.rdbPats.Text = "nurodysiu pats";
            this.rdbPats.UseVisualStyleBackColor = true;
            this.rdbPats.Click += new System.EventHandler(this.NPDSistNur);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaip skaičiuoti NPD?";
            // 
            // chkKaupPens
            // 
            this.chkKaupPens.AutoSize = true;
            this.chkKaupPens.Location = new System.Drawing.Point(539, 265);
            this.chkKaupPens.Name = "chkKaupPens";
            this.chkKaupPens.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkKaupPens.Size = new System.Drawing.Size(15, 14);
            this.chkKaupPens.TabIndex = 6;
            this.chkKaupPens.UseVisualStyleBackColor = true;
            this.chkKaupPens.CheckedChanged += new System.EventHandler(this.chkKaupPens_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // cmbPensProc
            // 
            this.cmbPensProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPensProc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPensProc.FormattingEnabled = true;
            this.cmbPensProc.Location = new System.Drawing.Point(469, 301);
            this.cmbPensProc.Name = "cmbPensProc";
            this.cmbPensProc.Size = new System.Drawing.Size(85, 21);
            this.cmbPensProc.TabIndex = 8;
            this.cmbPensProc.SelectedIndexChanged += new System.EventHandler(this.cmbPensProc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kiek?%";
            // 
            // txtNPDnur
            // 
            this.txtNPDnur.Location = new System.Drawing.Point(454, 214);
            this.txtNPDnur.Name = "txtNPDnur";
            this.txtNPDnur.Size = new System.Drawing.Size(100, 20);
            this.txtNPDnur.TabIndex = 10;
            this.txtNPDnur.Text = "0";
            this.txtNPDnur.TextChanged += new System.EventHandler(this.txtNPDnur_TextChanged);
            this.txtNPDnur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPDnur_KeyPress);
            // 
            // txtAtlyginimoStatusas
            // 
            this.txtAtlyginimoStatusas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtAtlyginimoStatusas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtlyginimoStatusas.Location = new System.Drawing.Point(123, 119);
            this.txtAtlyginimoStatusas.Name = "txtAtlyginimoStatusas";
            this.txtAtlyginimoStatusas.ReadOnly = true;
            this.txtAtlyginimoStatusas.Size = new System.Drawing.Size(90, 13);
            this.txtAtlyginimoStatusas.TabIndex = 11;
            this.txtAtlyginimoStatusas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Visa darbo vietos kaina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Sodra %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Išmokamas atlyginimas \"į rankas\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sodra. Pensijų ir soc. draudimas %\t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sodra. Sveikatos draudimas %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Pajamų mokestis %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Pritaikytas NPD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Priskaičiuotas atlyginimas \"ant popieriaus\"";
            // 
            // label95
            // 
            this.label95.Dock = System.Windows.Forms.DockStyle.Top;
            this.label95.Location = new System.Drawing.Point(0, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(591, 23);
            this.label95.TabIndex = 43;
            this.label95.Text = "ATLYGINIMO IR MOKESČIŲ SKAIČIUOKLĖ";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(26, 35);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(14, 16);
            this.label99.TabIndex = 44;
            this.label99.Text = "..";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 45;
            // 
            // apvalusMygtukasButton1
            // 
            this.apvalusMygtukasButton1.FlatAppearance.BorderSize = 0;
            this.apvalusMygtukasButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apvalusMygtukasButton1.Image = global::Atlyginimo_Skaiciavimo_Sistema.Properties.Resources.shutdown_26px;
            this.apvalusMygtukasButton1.Location = new System.Drawing.Point(549, 12);
            this.apvalusMygtukasButton1.Name = "apvalusMygtukasButton1";
            this.apvalusMygtukasButton1.Size = new System.Drawing.Size(30, 30);
            this.apvalusMygtukasButton1.TabIndex = 46;
            this.apvalusMygtukasButton1.UseVisualStyleBackColor = true;
            this.apvalusMygtukasButton1.Click += new System.EventHandler(this.apvalusMygtukasButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 452);
            this.Controls.Add(this.apvalusMygtukasButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAtlyginimoStatusas);
            this.Controls.Add(this.txtNPDnur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPensProc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkKaupPens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbPats);
            this.Controls.Add(this.rdbPaskSist);
            this.Controls.Add(this.AtlAntPopIrank);
            this.Controls.Add(this.AtlyginimasTXT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.AtlAntPopIrank.ResumeLayout(false);
            this.tbpAntPop.ResumeLayout(false);
            this.tbpIrank.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AtlyginimasTXT;
        private System.Windows.Forms.TabControl AtlAntPopIrank;
        private System.Windows.Forms.TabPage tbpAntPop;
        private System.Windows.Forms.RichTextBox Isvedimas;
        private System.Windows.Forms.TabPage tbpIrank;
        private System.Windows.Forms.RichTextBox Isvedimas2;
        private System.Windows.Forms.RadioButton rdbPaskSist;
        private System.Windows.Forms.RadioButton rdbPats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkKaupPens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPensProc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNPDnur;
        private System.Windows.Forms.TextBox txtAtlyginimoStatusas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label12;
        private ApvalusMygtukasButton apvalusMygtukasButton1;
    }
}

