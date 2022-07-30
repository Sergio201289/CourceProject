
namespace Курсач
{
    partial class EditSensors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSensors));
            this.Station = new System.Windows.Forms.TextBox();
            this.Volt = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.Purpose = new System.Windows.Forms.TextBox();
            this.Serial = new System.Windows.Forms.TextBox();
            this.Сохранить = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Station
            // 
            this.Station.Location = new System.Drawing.Point(79, 181);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(134, 20);
            this.Station.TabIndex = 9;
            // 
            // Volt
            // 
            this.Volt.Location = new System.Drawing.Point(79, 143);
            this.Volt.Name = "Volt";
            this.Volt.Size = new System.Drawing.Size(134, 20);
            this.Volt.TabIndex = 8;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(79, 103);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(134, 20);
            this.Type.TabIndex = 7;
            // 
            // Purpose
            // 
            this.Purpose.Location = new System.Drawing.Point(79, 63);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(134, 20);
            this.Purpose.TabIndex = 6;
            // 
            // Serial
            // 
            this.Serial.Location = new System.Drawing.Point(79, 28);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(134, 20);
            this.Serial.TabIndex = 5;
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(107, 223);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(75, 23);
            this.Сохранить.TabIndex = 10;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = true;
            this.Сохранить.Click += new System.EventHandler(this.Сохранить_Click);
            // 
            // EditSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 281);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.Volt);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.Serial);
            this.Name = "EditSensors";
            this.Text = "EditSensors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Station;
        private System.Windows.Forms.TextBox Volt;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox Purpose;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Button Сохранить;
    }
}