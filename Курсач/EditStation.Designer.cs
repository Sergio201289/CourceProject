
namespace Курсач
{
    partial class EditStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStation));
            this.Station = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.TextBox();
            this.Coordinates = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Station
            // 
            this.Station.Location = new System.Drawing.Point(119, 26);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(100, 20);
            this.Station.TabIndex = 0;
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(119, 68);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(100, 20);
            this.Line.TabIndex = 1;
            // 
            // Coordinates
            // 
            this.Coordinates.Location = new System.Drawing.Point(119, 111);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(100, 20);
            this.Coordinates.TabIndex = 2;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(88, 147);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(112, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Отредактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Станция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Участок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Координаты";
            // 
            // EditStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(288, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Station);
            this.Name = "EditStation";
            this.Text = "EditStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Station;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.TextBox Coordinates;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}