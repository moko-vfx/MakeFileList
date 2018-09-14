namespace MyTool_MakeFileList
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridViewResult = new System.Windows.Forms.DataGridView();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonListup = new System.Windows.Forms.Button();
			this.radioButtonFile = new System.Windows.Forms.RadioButton();
			this.radioButtonFolder = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewResult
			// 
			this.dataGridViewResult.AllowUserToAddRows = false;
			this.dataGridViewResult.AllowUserToDeleteRows = false;
			this.dataGridViewResult.AllowUserToResizeRows = false;
			this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(110)))), ((int)(((byte)(40)))));
			this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResult.Location = new System.Drawing.Point(14, 128);
			this.dataGridViewResult.Name = "dataGridViewResult";
			this.dataGridViewResult.ReadOnly = true;
			this.dataGridViewResult.RowHeadersVisible = false;
			this.dataGridViewResult.RowTemplate.Height = 21;
			this.dataGridViewResult.Size = new System.Drawing.Size(428, 140);
			this.dataGridViewResult.TabIndex = 8;
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClear.Location = new System.Drawing.Point(388, 100);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(53, 23);
			this.buttonClear.TabIndex = 6;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCopy.Location = new System.Drawing.Point(254, 100);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(128, 23);
			this.buttonCopy.TabIndex = 5;
			this.buttonCopy.Text = "Copy to Clipboard";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(48, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "File Data List";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(14, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(143, 22);
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxPath
			// 
			this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxPath.Location = new System.Drawing.Point(14, 37);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(428, 27);
			this.textBoxPath.TabIndex = 1;
			this.textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPath_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(425, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "フォルダパスを入力するかフォルダをドラッグ＆ドロップしてください";
			// 
			// buttonListup
			// 
			this.buttonListup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonListup.Location = new System.Drawing.Point(184, 99);
			this.buttonListup.Name = "buttonListup";
			this.buttonListup.Size = new System.Drawing.Size(64, 23);
			this.buttonListup.TabIndex = 4;
			this.buttonListup.Text = "List up";
			this.buttonListup.UseVisualStyleBackColor = true;
			this.buttonListup.Click += new System.EventHandler(this.buttonListup_Click);
			// 
			// radioButtonFile
			// 
			this.radioButtonFile.AutoSize = true;
			this.radioButtonFile.Checked = true;
			this.radioButtonFile.Location = new System.Drawing.Point(16, 71);
			this.radioButtonFile.Name = "radioButtonFile";
			this.radioButtonFile.Size = new System.Drawing.Size(65, 16);
			this.radioButtonFile.TabIndex = 2;
			this.radioButtonFile.TabStop = true;
			this.radioButtonFile.Text = "File List";
			this.radioButtonFile.UseVisualStyleBackColor = true;
			// 
			// radioButtonFolder
			// 
			this.radioButtonFolder.AutoSize = true;
			this.radioButtonFolder.Location = new System.Drawing.Point(87, 71);
			this.radioButtonFolder.Name = "radioButtonFolder";
			this.radioButtonFolder.Size = new System.Drawing.Size(78, 16);
			this.radioButtonFolder.TabIndex = 3;
			this.radioButtonFolder.TabStop = true;
			this.radioButtonFolder.Text = "Folder List";
			this.radioButtonFolder.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 282);
			this.Controls.Add(this.radioButtonFolder);
			this.Controls.Add(this.radioButtonFile);
			this.Controls.Add(this.dataGridViewResult);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonListup);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(450, 300);
			this.Name = "Form1";
			this.Text = "Make File List v.2.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewResult;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonListup;
		private System.Windows.Forms.RadioButton radioButtonFile;
		private System.Windows.Forms.RadioButton radioButtonFolder;
	}
}

