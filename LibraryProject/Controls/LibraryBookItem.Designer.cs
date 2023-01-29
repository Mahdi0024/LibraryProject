
namespace LibraryProject.Controls
{
    partial class LibraryBookItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namePictureBox = new System.Windows.Forms.PictureBox();
            this.authorPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.borrowButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // namePictureBox
            // 
            this.namePictureBox.Image = global::LibraryProject.Properties.Resources.bookIconSmall;
            this.namePictureBox.Location = new System.Drawing.Point(3, 3);
            this.namePictureBox.Name = "namePictureBox";
            this.namePictureBox.Size = new System.Drawing.Size(40, 54);
            this.namePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namePictureBox.TabIndex = 3;
            this.namePictureBox.TabStop = false;
            this.namePictureBox.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.namePictureBox.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // authorPictureBox
            // 
            this.authorPictureBox.Image = global::LibraryProject.Properties.Resources.AuthorIcon;
            this.authorPictureBox.Location = new System.Drawing.Point(3, 77);
            this.authorPictureBox.Name = "authorPictureBox";
            this.authorPictureBox.Size = new System.Drawing.Size(40, 54);
            this.authorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.authorPictureBox.TabIndex = 4;
            this.authorPictureBox.TabStop = false;
            this.authorPictureBox.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.authorPictureBox.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // descriptionPictureBox
            // 
            this.descriptionPictureBox.Image = global::LibraryProject.Properties.Resources.DescriptionIcon;
            this.descriptionPictureBox.Location = new System.Drawing.Point(3, 3);
            this.descriptionPictureBox.Name = "descriptionPictureBox";
            this.descriptionPictureBox.Size = new System.Drawing.Size(40, 54);
            this.descriptionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.descriptionPictureBox.TabIndex = 5;
            this.descriptionPictureBox.TabStop = false;
            this.descriptionPictureBox.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.descriptionPictureBox.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(172, 150);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.imagePictureBox.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.namelabel.Location = new System.Drawing.Point(49, 3);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(224, 54);
            this.namelabel.TabIndex = 8;
            this.namelabel.Text = "Name";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.namelabel.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.namelabel.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(244)))));
            this.authorLabel.Location = new System.Drawing.Point(49, 77);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(224, 54);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorLabel.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.authorLabel.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(217)))), ((int)(((byte)(229)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(49, 3);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(358, 135);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.descriptionTextBox.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // borrowButton
            // 
            this.borrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(149)))), ((int)(((byte)(74)))));
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowButton.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowButton.ForeColor = System.Drawing.Color.White;
            this.borrowButton.Location = new System.Drawing.Point(15, 50);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(105, 49);
            this.borrowButton.TabIndex = 11;
            this.borrowButton.Tag = "";
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            this.borrowButton.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.borrowButton.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 150);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.namePictureBox);
            this.panel2.Controls.Add(this.namelabel);
            this.panel2.Controls.Add(this.authorPictureBox);
            this.panel2.Controls.Add(this.authorLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 144);
            this.panel2.TabIndex = 0;
            this.panel2.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.descriptionPictureBox);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(285, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 144);
            this.panel3.TabIndex = 1;
            this.panel3.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.returnButton);
            this.panelButton.Controls.Add(this.borrowButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(876, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(134, 150);
            this.panelButton.TabIndex = 13;
            this.panelButton.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.panelButton.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(15, 50);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(105, 49);
            this.returnButton.TabIndex = 12;
            this.returnButton.Tag = "";
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            // 
            // LibraryBookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.imagePictureBox);
            this.Name = "LibraryBookItem";
            this.Size = new System.Drawing.Size(1010, 150);
            this.SizeChanged += new System.EventHandler(this.LibraryBookItem_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.LibraryBookItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LibraryBookItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.namePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox namePictureBox;
        private System.Windows.Forms.PictureBox authorPictureBox;
        private System.Windows.Forms.PictureBox descriptionPictureBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button returnButton;
    }
}
