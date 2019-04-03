namespace eBookManager
{
    partial class ImportBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBooks));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_ebook_to_storage_space.png");
            this.imageList1.Images.SetKeyName(1, "add_new_storage_space.png");
            this.imageList1.Images.SetKeyName(2, "docx16.png");
            this.imageList1.Images.SetKeyName(3, "docxx16.png");
            this.imageList1.Images.SetKeyName(4, "eBook.png");
            this.imageList1.Images.SetKeyName(5, "epubx16.png");
            this.imageList1.Images.SetKeyName(6, "folder_exp_x16.png");
            this.imageList1.Images.SetKeyName(7, "folder-close-x16.png");
            this.imageList1.Images.SetKeyName(8, "no_eBook.png");
            this.imageList1.Images.SetKeyName(9, "pdfx16.png");
            this.imageList1.Images.SetKeyName(10, "ReadEbook.png");
            this.imageList1.Images.SetKeyName(11, "storage_space_cloud.png");
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 1103);
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}