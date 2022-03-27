
namespace GestionStagiaire
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNote1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNote2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMoy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnAff = new System.Windows.Forms.Button();
            this.btnQui = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMoy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textNote2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textNote1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro Inscription ";
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(160, 58);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(160, 20);
            this.textNum.TabIndex = 1;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(160, 99);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(160, 20);
            this.textNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // textPre
            // 
            this.textPre.Location = new System.Drawing.Point(160, 141);
            this.textPre.Name = "textPre";
            this.textPre.Size = new System.Drawing.Size(160, 20);
            this.textPre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // textNote1
            // 
            this.textNote1.Location = new System.Drawing.Point(160, 180);
            this.textNote1.Name = "textNote1";
            this.textNote1.Size = new System.Drawing.Size(160, 20);
            this.textNote1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note1";
            // 
            // textNote2
            // 
            this.textNote2.Location = new System.Drawing.Point(160, 218);
            this.textNote2.Name = "textNote2";
            this.textNote2.Size = new System.Drawing.Size(160, 20);
            this.textNote2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Note2";
            // 
            // textMoy
            // 
            this.textMoy.Location = new System.Drawing.Point(160, 256);
            this.textMoy.Name = "textMoy";
            this.textMoy.ReadOnly = true;
            this.textMoy.Size = new System.Drawing.Size(160, 20);
            this.textMoy.TabIndex = 11;
            this.textMoy.TextChanged += new System.EventHandler(this.textMoy_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Moyenne";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQui);
            this.groupBox2.Controls.Add(this.btnAff);
            this.groupBox2.Controls.Add(this.btnAjout);
            this.groupBox2.Location = new System.Drawing.Point(466, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(92, 83);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnAff
            // 
            this.btnAff.Location = new System.Drawing.Point(92, 153);
            this.btnAff.Name = "btnAff";
            this.btnAff.Size = new System.Drawing.Size(75, 23);
            this.btnAff.TabIndex = 1;
            this.btnAff.Text = "Afficher";
            this.btnAff.UseVisualStyleBackColor = true;
            this.btnAff.Click += new System.EventHandler(this.btnAff_Click);
            // 
            // btnQui
            // 
            this.btnQui.Location = new System.Drawing.Point(92, 211);
            this.btnQui.Name = "btnQui";
            this.btnQui.Size = new System.Drawing.Size(75, 23);
            this.btnQui.TabIndex = 2;
            this.btnQui.Text = "Quitter";
            this.btnQui.UseVisualStyleBackColor = true;
            this.btnQui.Click += new System.EventHandler(this.btnQui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMoy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNote2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNote1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQui;
        private System.Windows.Forms.Button btnAff;
        private System.Windows.Forms.Button btnAjout;
    }
}

