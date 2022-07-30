
namespace Курсач
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.sensor = new System.Windows.Forms.Button();
            this.Станции = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sensor
            // 
            this.sensor.Location = new System.Drawing.Point(421, 298);
            this.sensor.Name = "sensor";
            this.sensor.Size = new System.Drawing.Size(75, 23);
            this.sensor.TabIndex = 0;
            this.sensor.Text = "Датчики";
            this.sensor.UseVisualStyleBackColor = true;
            this.sensor.Click += new System.EventHandler(this.sensor_Click);
            // 
            // Станции
            // 
            this.Станции.Location = new System.Drawing.Point(220, 298);
            this.Станции.Name = "Станции";
            this.Станции.Size = new System.Drawing.Size(75, 23);
            this.Станции.TabIndex = 1;
            this.Станции.Text = "Станции";
            this.Станции.UseVisualStyleBackColor = true;
            this.Станции.Click += new System.EventHandler(this.Станции_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Станции);
            this.Controls.Add(this.sensor);
            this.Name = "General";
            this.Text = "General";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sensor;
        private System.Windows.Forms.Button Станции;
    }
}