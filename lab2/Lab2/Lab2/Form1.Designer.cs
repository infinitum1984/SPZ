
namespace Lab2
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
            this.addPortBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPrichal = new System.Windows.Forms.ComboBox();
            this.textBoxShipTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxShipCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTechnicCoast = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPortName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.deletePortBtn = new System.Windows.Forms.Button();
            this.textBoxNumPrichal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPrichalBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumTech = new System.Windows.Forms.TextBox();
            this.textNumPeople = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePrichal = new System.Windows.Forms.Button();
            this.copyPort = new System.Windows.Forms.Button();
            this.savePrichal = new System.Windows.Forms.Button();
            this.savePortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPortBtn
            // 
            this.addPortBtn.Location = new System.Drawing.Point(357, 74);
            this.addPortBtn.Name = "addPortBtn";
            this.addPortBtn.Size = new System.Drawing.Size(111, 23);
            this.addPortBtn.TabIndex = 1;
            this.addPortBtn.Text = "Добавить порт";
            this.addPortBtn.UseVisualStyleBackColor = true;
            this.addPortBtn.Click += new System.EventHandler(this.addPortBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Управление портом";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(210, 76);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Выбрать порт";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Выбрать причал";
            // 
            // comboBoxPrichal
            // 
            this.comboBoxPrichal.FormattingEnabled = true;
            this.comboBoxPrichal.Location = new System.Drawing.Point(669, 75);
            this.comboBoxPrichal.Name = "comboBoxPrichal";
            this.comboBoxPrichal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrichal.TabIndex = 18;
            // 
            // textBoxShipTime
            // 
            this.textBoxShipTime.Location = new System.Drawing.Point(211, 249);
            this.textBoxShipTime.Name = "textBoxShipTime";
            this.textBoxShipTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxShipTime.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Время обсл. корабля:";
            // 
            // textBoxShipCost
            // 
            this.textBoxShipCost.Location = new System.Drawing.Point(210, 215);
            this.textBoxShipCost.Name = "textBoxShipCost";
            this.textBoxShipCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxShipCost.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Обс. корабля:";
            // 
            // textBoxTechnicCoast
            // 
            this.textBoxTechnicCoast.Location = new System.Drawing.Point(210, 181);
            this.textBoxTechnicCoast.Name = "textBoxTechnicCoast";
            this.textBoxTechnicCoast.Size = new System.Drawing.Size(100, 20);
            this.textBoxTechnicCoast.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Стоимость техники:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(210, 148);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Адрес порта:";
            // 
            // textBoxPortName
            // 
            this.textBoxPortName.Location = new System.Drawing.Point(210, 114);
            this.textBoxPortName.Name = "textBoxPortName";
            this.textBoxPortName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPortName.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Имя порта:";
            // 
            // deletePortBtn
            // 
            this.deletePortBtn.Location = new System.Drawing.Point(77, 327);
            this.deletePortBtn.Name = "deletePortBtn";
            this.deletePortBtn.Size = new System.Drawing.Size(98, 23);
            this.deletePortBtn.TabIndex = 32;
            this.deletePortBtn.Text = "Удалить порт";
            this.deletePortBtn.UseVisualStyleBackColor = true;
            this.deletePortBtn.Click += new System.EventHandler(this.deletePortBtn_Click);
            // 
            // textBoxNumPrichal
            // 
            this.textBoxNumPrichal.Location = new System.Drawing.Point(208, 288);
            this.textBoxNumPrichal.Name = "textBoxNumPrichal";
            this.textBoxNumPrichal.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumPrichal.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Кол. причалов:";
            // 
            // addPrichalBtn
            // 
            this.addPrichalBtn.Location = new System.Drawing.Point(843, 76);
            this.addPrichalBtn.Name = "addPrichalBtn";
            this.addPrichalBtn.Size = new System.Drawing.Size(157, 23);
            this.addPrichalBtn.TabIndex = 35;
            this.addPrichalBtn.Text = "Добавить новый причал";
            this.addPrichalBtn.UseVisualStyleBackColor = true;
            this.addPrichalBtn.Click += new System.EventHandler(this.addPrichalBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Кол. техники:";
            // 
            // textNumTech
            // 
            this.textNumTech.Location = new System.Drawing.Point(655, 129);
            this.textNumTech.Name = "textNumTech";
            this.textNumTech.Size = new System.Drawing.Size(100, 20);
            this.textNumTech.TabIndex = 37;
            // 
            // textNumPeople
            // 
            this.textNumPeople.Location = new System.Drawing.Point(655, 184);
            this.textNumPeople.Name = "textNumPeople";
            this.textNumPeople.Size = new System.Drawing.Size(100, 20);
            this.textNumPeople.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Кол. рабочих:";
            // 
            // deletePrichal
            // 
            this.deletePrichal.Location = new System.Drawing.Point(580, 249);
            this.deletePrichal.Name = "deletePrichal";
            this.deletePrichal.Size = new System.Drawing.Size(131, 23);
            this.deletePrichal.TabIndex = 40;
            this.deletePrichal.Text = "Удалить причал";
            this.deletePrichal.UseVisualStyleBackColor = true;
            this.deletePrichal.Click += new System.EventHandler(this.deletePrichal_Click);
            // 
            // copyPort
            // 
            this.copyPort.Location = new System.Drawing.Point(48, 370);
            this.copyPort.Name = "copyPort";
            this.copyPort.Size = new System.Drawing.Size(127, 23);
            this.copyPort.TabIndex = 42;
            this.copyPort.Text = "Создать копию порта";
            this.copyPort.UseVisualStyleBackColor = true;
            // 
            // savePrichal
            // 
            this.savePrichal.Location = new System.Drawing.Point(755, 249);
            this.savePrichal.Name = "savePrichal";
            this.savePrichal.Size = new System.Drawing.Size(75, 23);
            this.savePrichal.TabIndex = 41;
            this.savePrichal.Text = "Сохранить";
            this.savePrichal.UseVisualStyleBackColor = true;
            this.savePrichal.Click += new System.EventHandler(this.savePrichal_Click);
            // 
            // savePortBtn
            // 
            this.savePortBtn.Location = new System.Drawing.Point(236, 327);
            this.savePortBtn.Name = "savePortBtn";
            this.savePortBtn.Size = new System.Drawing.Size(75, 23);
            this.savePortBtn.TabIndex = 31;
            this.savePortBtn.Text = "Сохранить";
            this.savePortBtn.UseVisualStyleBackColor = true;
            this.savePortBtn.Click += new System.EventHandler(this.savePortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 588);
            this.Controls.Add(this.copyPort);
            this.Controls.Add(this.savePrichal);
            this.Controls.Add(this.deletePrichal);
            this.Controls.Add(this.textNumPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNumTech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPrichalBtn);
            this.Controls.Add(this.textBoxNumPrichal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePortBtn);
            this.Controls.Add(this.savePortBtn);
            this.Controls.Add(this.textBoxShipTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxShipCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxTechnicCoast);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxPortName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxPrichal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addPortBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPortBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxPrichal;
        private System.Windows.Forms.TextBox textBoxShipTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxShipCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTechnicCoast;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPortName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button deletePortBtn;
        private System.Windows.Forms.TextBox textBoxNumPrichal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPrichalBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumTech;
        private System.Windows.Forms.TextBox textNumPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deletePrichal;
        private System.Windows.Forms.Button copyPort;
        private System.Windows.Forms.Button savePrichal;
        private System.Windows.Forms.Button savePortBtn;
    }
}

