namespace WCFServiceForm
{
    partial class Form1
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
            this.rz_1 = new System.Windows.Forms.TextBox();
            this.ur_1 = new System.Windows.Forms.TextBox();
            this.rz_2 = new System.Windows.Forms.TextBox();
            this.ur_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodawanieButton = new System.Windows.Forms.Button();
            this.odejmowanieButton = new System.Windows.Forms.Button();
            this.mnozenieButton = new System.Windows.Forms.Button();
            this.dzielenieButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rz_1
            // 
            this.rz_1.Location = new System.Drawing.Point(16, 36);
            this.rz_1.Name = "rz_1";
            this.rz_1.Size = new System.Drawing.Size(100, 22);
            this.rz_1.TabIndex = 0;
            // 
            // ur_1
            // 
            this.ur_1.Location = new System.Drawing.Point(122, 36);
            this.ur_1.Name = "ur_1";
            this.ur_1.Size = new System.Drawing.Size(100, 22);
            this.ur_1.TabIndex = 1;
            // 
            // rz_2
            // 
            this.rz_2.Location = new System.Drawing.Point(286, 36);
            this.rz_2.Name = "rz_2";
            this.rz_2.Size = new System.Drawing.Size(100, 22);
            this.rz_2.TabIndex = 2;
            // 
            // ur_2
            // 
            this.ur_2.Location = new System.Drawing.Point(392, 36);
            this.ur_2.Name = "ur_2";
            this.ur_2.Size = new System.Drawing.Size(100, 22);
            this.ur_2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pierwsza liczba zespolona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Druga liczba zespolona";
            // 
            // dodawanieButton
            // 
            this.dodawanieButton.Location = new System.Drawing.Point(36, 85);
            this.dodawanieButton.Name = "dodawanieButton";
            this.dodawanieButton.Size = new System.Drawing.Size(103, 47);
            this.dodawanieButton.TabIndex = 6;
            this.dodawanieButton.Text = "Dodawanie";
            this.dodawanieButton.UseVisualStyleBackColor = true;
            this.dodawanieButton.Click += new System.EventHandler(this.dodawanieButton_Click);
            // 
            // odejmowanieButton
            // 
            this.odejmowanieButton.Location = new System.Drawing.Point(145, 85);
            this.odejmowanieButton.Name = "odejmowanieButton";
            this.odejmowanieButton.Size = new System.Drawing.Size(103, 47);
            this.odejmowanieButton.TabIndex = 7;
            this.odejmowanieButton.Text = "Odejmowanie";
            this.odejmowanieButton.UseVisualStyleBackColor = true;
            this.odejmowanieButton.Click += new System.EventHandler(this.odejmowanieButton_Click);
            // 
            // mnozenieButton
            // 
            this.mnozenieButton.Location = new System.Drawing.Point(254, 85);
            this.mnozenieButton.Name = "mnozenieButton";
            this.mnozenieButton.Size = new System.Drawing.Size(103, 47);
            this.mnozenieButton.TabIndex = 8;
            this.mnozenieButton.Text = "Mnozenie";
            this.mnozenieButton.UseVisualStyleBackColor = true;
            this.mnozenieButton.Click += new System.EventHandler(this.mnozenieButton_Click);
            // 
            // dzielenieButton
            // 
            this.dzielenieButton.Location = new System.Drawing.Point(363, 85);
            this.dzielenieButton.Name = "dzielenieButton";
            this.dzielenieButton.Size = new System.Drawing.Size(103, 47);
            this.dzielenieButton.TabIndex = 9;
            this.dzielenieButton.Text = "Dzielenie";
            this.dzielenieButton.UseVisualStyleBackColor = true;
            this.dzielenieButton.Click += new System.EventHandler(this.dzielenieButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(31, 191);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(102, 20);
            this.Label.TabIndex = 10;
            this.Label.Text = "Odpowiedz: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(145, 194);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 259);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.dzielenieButton);
            this.Controls.Add(this.mnozenieButton);
            this.Controls.Add(this.odejmowanieButton);
            this.Controls.Add(this.dodawanieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ur_2);
            this.Controls.Add(this.rz_2);
            this.Controls.Add(this.ur_1);
            this.Controls.Add(this.rz_1);
            this.Name = "Form1";
            this.Text = "WCFServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rz_1;
        private System.Windows.Forms.TextBox ur_1;
        private System.Windows.Forms.TextBox rz_2;
        private System.Windows.Forms.TextBox ur_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodawanieButton;
        private System.Windows.Forms.Button odejmowanieButton;
        private System.Windows.Forms.Button mnozenieButton;
        private System.Windows.Forms.Button dzielenieButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label resultLabel;
    }
}

