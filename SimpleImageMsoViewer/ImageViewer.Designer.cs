namespace SimpleImageMsoViewer
{
    partial class ImageViewer
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
            this.dgImages = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImages
            // 
            this.dgImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImages.Location = new System.Drawing.Point(0, 35);
            this.dgImages.Name = "dgImages";
            this.dgImages.RowTemplate.Height = 36;
            this.dgImages.Size = new System.Drawing.Size(797, 802);
            this.dgImages.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.BackColor = System.Drawing.SystemColors.Info;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(66, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(731, 29);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter";
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 837);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgImages);
            this.Name = "ImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgImages;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
    }
}