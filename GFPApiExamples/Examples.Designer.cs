namespace GFPApiExamples
{
    partial class Examples
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
            this.examplesTabControl = new System.Windows.Forms.TabControl();
            this.photosTabPage = new System.Windows.Forms.TabPage();
            this.getPhotos = new System.Windows.Forms.Button();
            this.putHighResImage = new System.Windows.Forms.Button();
            this.putLowResImage = new System.Windows.Forms.Button();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.serverAddress = new System.Windows.Forms.TextBox();
            this.apiKey = new System.Windows.Forms.TextBox();
            this.validPhotoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getPhoto = new System.Windows.Forms.Button();
            this.examplesTabControl.SuspendLayout();
            this.photosTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // examplesTabControl
            // 
            this.examplesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examplesTabControl.Controls.Add(this.photosTabPage);
            this.examplesTabControl.Location = new System.Drawing.Point(0, 70);
            this.examplesTabControl.Name = "examplesTabControl";
            this.examplesTabControl.SelectedIndex = 0;
            this.examplesTabControl.Size = new System.Drawing.Size(772, 489);
            this.examplesTabControl.TabIndex = 0;
            // 
            // photosTabPage
            // 
            this.photosTabPage.Controls.Add(this.getPhoto);
            this.photosTabPage.Controls.Add(this.validPhotoId);
            this.photosTabPage.Controls.Add(this.label1);
            this.photosTabPage.Controls.Add(this.getPhotos);
            this.photosTabPage.Controls.Add(this.putHighResImage);
            this.photosTabPage.Controls.Add(this.putLowResImage);
            this.photosTabPage.Location = new System.Drawing.Point(4, 22);
            this.photosTabPage.Name = "photosTabPage";
            this.photosTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.photosTabPage.Size = new System.Drawing.Size(764, 463);
            this.photosTabPage.TabIndex = 1;
            this.photosTabPage.Text = "Photos API";
            this.photosTabPage.UseVisualStyleBackColor = true;
            // 
            // getPhotos
            // 
            this.getPhotos.Location = new System.Drawing.Point(232, 122);
            this.getPhotos.Name = "getPhotos";
            this.getPhotos.Size = new System.Drawing.Size(134, 62);
            this.getPhotos.TabIndex = 2;
            this.getPhotos.Text = "GET Photos";
            this.getPhotos.UseVisualStyleBackColor = true;
            this.getPhotos.Click += new System.EventHandler(this.getPhotos_Click);
            // 
            // putHighResImage
            // 
            this.putHighResImage.Location = new System.Drawing.Point(512, 223);
            this.putHighResImage.Name = "putHighResImage";
            this.putHighResImage.Size = new System.Drawing.Size(134, 62);
            this.putHighResImage.TabIndex = 1;
            this.putHighResImage.Text = "PUT HighResImage";
            this.putHighResImage.UseVisualStyleBackColor = true;
            this.putHighResImage.Click += new System.EventHandler(this.putHighResImage_Click);
            // 
            // putLowResImage
            // 
            this.putLowResImage.Location = new System.Drawing.Point(372, 223);
            this.putLowResImage.Name = "putLowResImage";
            this.putLowResImage.Size = new System.Drawing.Size(134, 62);
            this.putLowResImage.TabIndex = 0;
            this.putLowResImage.Text = "PUT LowResImage";
            this.putLowResImage.UseVisualStyleBackColor = true;
            this.putLowResImage.Click += new System.EventHandler(this.uploadLowResImage_Click);
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverAddressLabel.Location = new System.Drawing.Point(12, 20);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(97, 13);
            this.serverAddressLabel.TabIndex = 2;
            this.serverAddressLabel.Text = "Server Address:";
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiKeyLabel.Location = new System.Drawing.Point(15, 43);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(56, 13);
            this.apiKeyLabel.TabIndex = 3;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // serverAddress
            // 
            this.serverAddress.Location = new System.Drawing.Point(115, 20);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(653, 20);
            this.serverAddress.TabIndex = 2;
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(115, 44);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(653, 20);
            this.apiKey.TabIndex = 4;
            // 
            // validPhotoId
            // 
            this.validPhotoId.Location = new System.Drawing.Point(327, 197);
            this.validPhotoId.Name = "validPhotoId";
            this.validPhotoId.Size = new System.Drawing.Size(100, 20);
            this.validPhotoId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valid Image Id:";
            // 
            // getPhoto
            // 
            this.getPhoto.Location = new System.Drawing.Point(232, 223);
            this.getPhoto.Name = "getPhoto";
            this.getPhoto.Size = new System.Drawing.Size(134, 62);
            this.getPhoto.TabIndex = 8;
            this.getPhoto.Text = "GET Photo";
            this.getPhoto.UseVisualStyleBackColor = true;
            this.getPhoto.Click += new System.EventHandler(this.getPhoto_Click);
            // 
            // Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.apiKey);
            this.Controls.Add(this.serverAddress);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.serverAddressLabel);
            this.Controls.Add(this.examplesTabControl);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Examples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GFP API Examples";
            this.examplesTabControl.ResumeLayout(false);
            this.photosTabPage.ResumeLayout(false);
            this.photosTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl examplesTabControl;
        private System.Windows.Forms.TabPage photosTabPage;
        private System.Windows.Forms.Button putLowResImage;
        private System.Windows.Forms.Button putHighResImage;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox serverAddress;
        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.Button getPhotos;
        private System.Windows.Forms.Button getPhoto;
        private System.Windows.Forms.TextBox validPhotoId;
        private System.Windows.Forms.Label label1;
    }
}