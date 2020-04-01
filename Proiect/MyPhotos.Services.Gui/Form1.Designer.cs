namespace MyPhotos.DataAccess.Gui
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
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnPlaces = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnPhotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTypes
            // 
            this.btnTypes.Location = new System.Drawing.Point(66, 44);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(79, 76);
            this.btnTypes.TabIndex = 0;
            this.btnTypes.Text = "Types";
            this.btnTypes.UseVisualStyleBackColor = true;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // btnPlaces
            // 
            this.btnPlaces.Location = new System.Drawing.Point(181, 44);
            this.btnPlaces.Name = "btnPlaces";
            this.btnPlaces.Size = new System.Drawing.Size(79, 76);
            this.btnPlaces.TabIndex = 1;
            this.btnPlaces.Text = "Places";
            this.btnPlaces.UseVisualStyleBackColor = true;
            this.btnPlaces.Click += new System.EventHandler(this.btnPlaces_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(298, 44);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(79, 76);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(66, 151);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(79, 76);
            this.btnPeople.TabIndex = 3;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnPhotos
            // 
            this.btnPhotos.Location = new System.Drawing.Point(181, 151);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(79, 76);
            this.btnPhotos.TabIndex = 4;
            this.btnPhotos.Text = "Photos";
            this.btnPhotos.UseVisualStyleBackColor = true;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.btnPhotos);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnPlaces);
            this.Controls.Add(this.btnTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnPlaces;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnPhotos;
    }
}

