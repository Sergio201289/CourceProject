
namespace Курсач
{
    partial class CreateSensor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSensor));
            this.Serial = new System.Windows.Forms.TextBox();
            this.Purpose = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Volt = new System.Windows.Forms.TextBox();
            this.Station = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.Location = new System.Drawing.Point(154, 38);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(134, 20);
            this.Serial.TabIndex = 0;
            // 
            // Purpose
            // 
            this.Purpose.Location = new System.Drawing.Point(154, 73);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(134, 20);
            this.Purpose.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(154, 113);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(134, 20);
            this.Type.TabIndex = 2;
            // 
            // Volt
            // 
            this.Volt.Location = new System.Drawing.Point(154, 153);
            this.Volt.Name = "Volt";
            this.Volt.Size = new System.Drawing.Size(134, 20);
            this.Volt.TabIndex = 3;
            // 
            // Station
            // 
            this.Station.Location = new System.Drawing.Point(154, 191);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(134, 20);
            this.Station.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Серийный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Назначение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вольтаж";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Станция";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(137, 237);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CreateSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 319);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.Volt);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.Serial);
            this.Name = "CreateSensor";
            this.Text = "CreateSensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.TextBox Purpose;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Volt;
        private System.Windows.Forms.TextBox Station;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
    }
}