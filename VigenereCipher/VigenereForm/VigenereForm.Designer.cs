
namespace VigenereForm
{
    partial class VigenereForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VigenereForm));
            this.CryptMessageBox = new System.Windows.Forms.TextBox();
            this.CryptKeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CipherBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveCipherToFileBTN = new System.Windows.Forms.Button();
            this.LoadMessageFromFileBTN = new System.Windows.Forms.Button();
            this.CryptCipherBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveMessageFromFileBTN = new System.Windows.Forms.Button();
            this.LoadCipherFromFileBTN = new System.Windows.Forms.Button();
            this.DecryptMessageBox = new System.Windows.Forms.TextBox();
            this.DecryptCipherBox = new System.Windows.Forms.TextBox();
            this.DecryptBTN = new System.Windows.Forms.Button();
            this.DecryptKeyBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptMessageBox
            // 
            resources.ApplyResources(this.CryptMessageBox, "CryptMessageBox");
            this.CryptMessageBox.Name = "CryptMessageBox";
            // 
            // CryptKeyBox
            // 
            resources.ApplyResources(this.CryptKeyBox, "CryptKeyBox");
            this.CryptKeyBox.Name = "CryptKeyBox";
            this.CryptKeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CipherBTN
            // 
            resources.ApplyResources(this.CipherBTN, "CipherBTN");
            this.CipherBTN.Name = "CipherBTN";
            this.CipherBTN.UseVisualStyleBackColor = true;
            this.CipherBTN.Click += new System.EventHandler(this.CipherBTN_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SaveCipherToFileBTN);
            this.groupBox1.Controls.Add(this.LoadMessageFromFileBTN);
            this.groupBox1.Controls.Add(this.CryptCipherBox);
            this.groupBox1.Controls.Add(this.CryptMessageBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CipherBTN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CryptKeyBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SaveCipherToFileBTN
            // 
            resources.ApplyResources(this.SaveCipherToFileBTN, "SaveCipherToFileBTN");
            this.SaveCipherToFileBTN.Name = "SaveCipherToFileBTN";
            this.SaveCipherToFileBTN.UseVisualStyleBackColor = true;
            this.SaveCipherToFileBTN.Click += new System.EventHandler(this.SaveCipherToFileBTN_Click);
            // 
            // LoadMessageFromFileBTN
            // 
            resources.ApplyResources(this.LoadMessageFromFileBTN, "LoadMessageFromFileBTN");
            this.LoadMessageFromFileBTN.Name = "LoadMessageFromFileBTN";
            this.LoadMessageFromFileBTN.UseVisualStyleBackColor = true;
            this.LoadMessageFromFileBTN.Click += new System.EventHandler(this.LoadMessageFromFileBTN_Click);
            // 
            // CryptCipherBox
            // 
            resources.ApplyResources(this.CryptCipherBox, "CryptCipherBox");
            this.CryptCipherBox.Name = "CryptCipherBox";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SaveMessageFromFileBTN);
            this.groupBox2.Controls.Add(this.LoadCipherFromFileBTN);
            this.groupBox2.Controls.Add(this.DecryptMessageBox);
            this.groupBox2.Controls.Add(this.DecryptCipherBox);
            this.groupBox2.Controls.Add(this.DecryptBTN);
            this.groupBox2.Controls.Add(this.DecryptKeyBox);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // SaveMessageFromFileBTN
            // 
            resources.ApplyResources(this.SaveMessageFromFileBTN, "SaveMessageFromFileBTN");
            this.SaveMessageFromFileBTN.Name = "SaveMessageFromFileBTN";
            this.SaveMessageFromFileBTN.UseVisualStyleBackColor = true;
            this.SaveMessageFromFileBTN.Click += new System.EventHandler(this.SaveMessageFromFileBTN_Click);
            // 
            // LoadCipherFromFileBTN
            // 
            resources.ApplyResources(this.LoadCipherFromFileBTN, "LoadCipherFromFileBTN");
            this.LoadCipherFromFileBTN.Name = "LoadCipherFromFileBTN";
            this.LoadCipherFromFileBTN.UseVisualStyleBackColor = true;
            this.LoadCipherFromFileBTN.Click += new System.EventHandler(this.LoadCipherFromFileBTN_Click);
            // 
            // DecryptMessageBox
            // 
            resources.ApplyResources(this.DecryptMessageBox, "DecryptMessageBox");
            this.DecryptMessageBox.Name = "DecryptMessageBox";
            // 
            // DecryptCipherBox
            // 
            resources.ApplyResources(this.DecryptCipherBox, "DecryptCipherBox");
            this.DecryptCipherBox.Name = "DecryptCipherBox";
            // 
            // DecryptBTN
            // 
            resources.ApplyResources(this.DecryptBTN, "DecryptBTN");
            this.DecryptBTN.Name = "DecryptBTN";
            this.DecryptBTN.UseVisualStyleBackColor = true;
            this.DecryptBTN.Click += new System.EventHandler(this.DecryptBTN_Click);
            // 
            // DecryptKeyBox
            // 
            resources.ApplyResources(this.DecryptKeyBox, "DecryptKeyBox");
            this.DecryptKeyBox.Name = "DecryptKeyBox";
            this.DecryptKeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // VigenereForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VigenereForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CryptMessageBox;
        private System.Windows.Forms.TextBox CryptKeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CipherBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CryptCipherBox;
        private System.Windows.Forms.Button SaveCipherToFileBTN;
        private System.Windows.Forms.Button LoadMessageFromFileBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveMessageFromFileBTN;
        private System.Windows.Forms.Button LoadCipherFromFileBTN;
        private System.Windows.Forms.TextBox DecryptMessageBox;
        private System.Windows.Forms.TextBox DecryptCipherBox;
        private System.Windows.Forms.Button DecryptBTN;
        private System.Windows.Forms.TextBox DecryptKeyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

