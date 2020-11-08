namespace Yemek_Sepeti___Hızlı_Yapistir
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnaddList = new System.Windows.Forms.Button();
            this.tbShortcutElement = new System.Windows.Forms.TextBox();
            this.lbShortcutList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeSelectedItem = new System.Windows.Forms.Button();
            this.AddElementLabel = new System.Windows.Forms.Label();
            this.lbShortcutListIndex = new System.Windows.Forms.ListBox();
            this.startListenKey = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.lbStateValue = new System.Windows.Forms.Label();
            this.chooseFromFile = new System.Windows.Forms.Button();
            this.deleteAllElementFromShortcutList = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddList
            // 
            this.btnaddList.BackColor = System.Drawing.Color.Lime;
            this.btnaddList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddList.ForeColor = System.Drawing.Color.White;
            this.btnaddList.Location = new System.Drawing.Point(129, 219);
            this.btnaddList.Name = "btnaddList";
            this.btnaddList.Size = new System.Drawing.Size(135, 23);
            this.btnaddList.TabIndex = 0;
            this.btnaddList.Text = " Ekle";
            this.btnaddList.UseVisualStyleBackColor = false;
            this.btnaddList.Click += new System.EventHandler(this.btnaddList_Click);
            // 
            // tbShortcutElement
            // 
            this.tbShortcutElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbShortcutElement.Location = new System.Drawing.Point(21, 183);
            this.tbShortcutElement.Multiline = true;
            this.tbShortcutElement.Name = "tbShortcutElement";
            this.tbShortcutElement.Size = new System.Drawing.Size(340, 30);
            this.tbShortcutElement.TabIndex = 1;
            // 
            // lbShortcutList
            // 
            this.lbShortcutList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbShortcutList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShortcutList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbShortcutList.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShortcutList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbShortcutList.FormattingEnabled = true;
            this.lbShortcutList.ItemHeight = 22;
            this.lbShortcutList.Location = new System.Drawing.Point(441, 95);
            this.lbShortcutList.Name = "lbShortcutList";
            this.lbShortcutList.Size = new System.Drawing.Size(347, 288);
            this.lbShortcutList.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // removeSelectedItem
            // 
            this.removeSelectedItem.BackColor = System.Drawing.Color.Red;
            this.removeSelectedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeSelectedItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSelectedItem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedItem.ForeColor = System.Drawing.Color.White;
            this.removeSelectedItem.Location = new System.Drawing.Point(523, 396);
            this.removeSelectedItem.Name = "removeSelectedItem";
            this.removeSelectedItem.Size = new System.Drawing.Size(195, 23);
            this.removeSelectedItem.TabIndex = 4;
            this.removeSelectedItem.Text = "Seçilen Elemanı Çıkar";
            this.removeSelectedItem.UseVisualStyleBackColor = false;
            this.removeSelectedItem.Click += new System.EventHandler(this.removeSelectedItem_Click);
            // 
            // AddElementLabel
            // 
            this.AddElementLabel.AutoSize = true;
            this.AddElementLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddElementLabel.ForeColor = System.Drawing.Color.White;
            this.AddElementLabel.Location = new System.Drawing.Point(92, 166);
            this.AddElementLabel.Name = "AddElementLabel";
            this.AddElementLabel.Size = new System.Drawing.Size(210, 14);
            this.AddElementLabel.TabIndex = 5;
            this.AddElementLabel.Text = "Kısayol Listesine Eleman Ekle";
            // 
            // lbShortcutListIndex
            // 
            this.lbShortcutListIndex.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbShortcutListIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShortcutListIndex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbShortcutListIndex.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShortcutListIndex.ForeColor = System.Drawing.Color.Red;
            this.lbShortcutListIndex.FormattingEnabled = true;
            this.lbShortcutListIndex.ItemHeight = 22;
            this.lbShortcutListIndex.Location = new System.Drawing.Point(373, 95);
            this.lbShortcutListIndex.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.lbShortcutListIndex.Name = "lbShortcutListIndex";
            this.lbShortcutListIndex.Size = new System.Drawing.Size(66, 288);
            this.lbShortcutListIndex.TabIndex = 6;
            // 
            // startListenKey
            // 
            this.startListenKey.BackColor = System.Drawing.Color.Green;
            this.startListenKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startListenKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startListenKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startListenKey.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startListenKey.ForeColor = System.Drawing.Color.White;
            this.startListenKey.Location = new System.Drawing.Point(122, 277);
            this.startListenKey.Name = "startListenKey";
            this.startListenKey.Size = new System.Drawing.Size(146, 31);
            this.startListenKey.TabIndex = 7;
            this.startListenKey.Text = "Programı Başlat";
            this.startListenKey.UseVisualStyleBackColor = false;
            this.startListenKey.Click += new System.EventHandler(this.startListenKey_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbState.Location = new System.Drawing.Point(18, 22);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(159, 13);
            this.lbState.TabIndex = 8;
            this.lbState.Text = "Program Çalışma Durumu : ";
            // 
            // lbStateValue
            // 
            this.lbStateValue.AutoSize = true;
            this.lbStateValue.BackColor = System.Drawing.Color.Transparent;
            this.lbStateValue.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStateValue.ForeColor = System.Drawing.Color.Red;
            this.lbStateValue.Location = new System.Drawing.Point(172, 17);
            this.lbStateValue.Name = "lbStateValue";
            this.lbStateValue.Size = new System.Drawing.Size(65, 22);
            this.lbStateValue.TabIndex = 9;
            this.lbStateValue.Text = "Deaktif";
            this.lbStateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chooseFromFile
            // 
            this.chooseFromFile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.chooseFromFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chooseFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseFromFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFromFile.ForeColor = System.Drawing.Color.White;
            this.chooseFromFile.Location = new System.Drawing.Point(12, 352);
            this.chooseFromFile.Name = "chooseFromFile";
            this.chooseFromFile.Size = new System.Drawing.Size(146, 31);
            this.chooseFromFile.TabIndex = 10;
            this.chooseFromFile.Text = "Dosyadan Seç";
            this.chooseFromFile.UseVisualStyleBackColor = false;
            this.chooseFromFile.Click += new System.EventHandler(this.chooseFromFile_Click);
            // 
            // deleteAllElementFromShortcutList
            // 
            this.deleteAllElementFromShortcutList.BackColor = System.Drawing.Color.Red;
            this.deleteAllElementFromShortcutList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteAllElementFromShortcutList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllElementFromShortcutList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAllElementFromShortcutList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllElementFromShortcutList.ForeColor = System.Drawing.Color.White;
            this.deleteAllElementFromShortcutList.Location = new System.Drawing.Point(553, 425);
            this.deleteAllElementFromShortcutList.Name = "deleteAllElementFromShortcutList";
            this.deleteAllElementFromShortcutList.Size = new System.Drawing.Size(140, 23);
            this.deleteAllElementFromShortcutList.TabIndex = 11;
            this.deleteAllElementFromShortcutList.Text = "Tümünü Sil";
            this.deleteAllElementFromShortcutList.UseVisualStyleBackColor = false;
            this.deleteAllElementFromShortcutList.Click += new System.EventHandler(this.deleteAllElementFromShortcutList_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbInfo.Location = new System.Drawing.Point(10, 434);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(210, 9);
            this.lbInfo.TabIndex = 12;
            this.lbInfo.Text = "Created by Bahadır Yalın  &&  Emin Aydoğar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Demo v1.1210";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnaddList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.deleteAllElementFromShortcutList);
            this.Controls.Add(this.chooseFromFile);
            this.Controls.Add(this.lbStateValue);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.startListenKey);
            this.Controls.Add(this.lbShortcutListIndex);
            this.Controls.Add(this.AddElementLabel);
            this.Controls.Add(this.removeSelectedItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbShortcutList);
            this.Controls.Add(this.tbShortcutElement);
            this.Controls.Add(this.btnaddList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yemek Sepeti - Yapistir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddList;
        private System.Windows.Forms.TextBox tbShortcutElement;
        private System.Windows.Forms.ListBox lbShortcutList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removeSelectedItem;
        private System.Windows.Forms.Label AddElementLabel;
        private System.Windows.Forms.ListBox lbShortcutListIndex;
        private System.Windows.Forms.Button startListenKey;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbStateValue;
        private System.Windows.Forms.Button chooseFromFile;
        private System.Windows.Forms.Button deleteAllElementFromShortcutList;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
    }
}

