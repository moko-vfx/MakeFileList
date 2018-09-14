using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_MakeFileList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Form Load イベント
		private void Form1_Load(object sender, EventArgs e)
		{
			// カラム数を指定
			dataGridViewResult.ColumnCount = 5;

			// カラム名を指定
			dataGridViewResult.Columns[0].HeaderText = "pass";
			dataGridViewResult.Columns[1].HeaderText = "name";
			dataGridViewResult.Columns[2].HeaderText = "size(Byte)";
			dataGridViewResult.Columns[3].HeaderText = "size(KB)";
			dataGridViewResult.Columns[4].HeaderText = "size(MB)";

			// サイズ表示列を右寄せにする
			dataGridViewResult.Columns[2].DefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleRight;
			dataGridViewResult.Columns[3].DefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleRight;
			dataGridViewResult.Columns[4].DefaultCellStyle.Alignment =
				DataGridViewContentAlignment.MiddleRight;
		}

		// Form へのドラッグ＆ドロップの挙動 1
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			//ドロップされたものがファイルかどうかチェックする定番の書き方
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				//ファイルのときは受け付ける
				e.Effect = DragDropEffects.All;
			}
			else
			{
				//ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
			}
		}
		// Form へのドラッグ＆ドロップの挙動 2
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			//ファイルが複数ドロップされた時のためにフルパスを配列に代入
			string[] multiPass = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			
			//0番目のファイルだけフルパスを取得
			string filePass = multiPass[0];
			
			//ファイルかフォルダかを判定してフォルダパスを取得
			if (File.Exists(filePass))				//ファイルの場合
			{
				textBoxPath.Text = Path.GetDirectoryName(filePass);
			}
			else if (Directory.Exists(filePass))	//フォルダの場合
			{
				textBoxPath.Text = filePass;
			}
		}

		// TextBox のキー入力イベント
		private void textBoxPath_KeyDown(object sender, KeyEventArgs e)
		{
			// Ctrl + A で全選択可能にする
			if (e.Control && e.KeyCode == Keys.A)
			{
				textBoxPath.SelectAll();
			}
		}

		// Listup Button の挙動
		private void buttonListup_Click(object sender, EventArgs e)
		{
			// 指定したフォルダパスが存在する場合のみ実行する
			if (Directory.Exists(textBoxPath.Text))
			{
				// 全ての行の内容をクリア
				dataGridViewResult.Rows.Clear();

				

				// 指定のフォルダ以下にあるファイルを全て取得
				// アクセスできないフォルダも存在するので例外対策しておく
				try
				{
					// Radio Button の選択に合わせて処理を分岐する
					// File List を作成する
					if (radioButtonFile.Checked == true)
					{
						string[] files = Directory.GetFiles(
							textBoxPath.Text, "*", SearchOption.AllDirectories);

						// 調べる総ファイル数を取得
						int count = files.Length;

						// 配列の定義
						string[] pass = new string[count];
						string[] name = new string[count];
						long[] size = new long[count];

						// ファイル名とファイルサイズを取得して配列に格納
						for (int i = 0; i < count; i++)
						{
							pass[i] = Path.GetDirectoryName(files[i]);

							name[i] = Path.GetFileName(files[i]);

							FileInfo fi = new FileInfo(files[i]);
							size[i] = fi.Length;
						}

						// DataGridView に追加していく
						for (int i = 0; i < count; i++)
						{
							double b = size[i];                      // Byte
							double kb = Math.Round(b / 1024, 1);    // KiB換算
							double mb = Math.Round(kb / 1024, 1);   // MiB換算

							dataGridViewResult.Rows.Add(pass[i], name[i], b, kb, mb);
						}
					}
					// Folder List を作成する
					else if (radioButtonFile.Checked == false)
					{
						string[] folders = Directory.GetDirectories(
							textBoxPath.Text, "*", SearchOption.AllDirectories);

						// 調べる総ファイル数を取得
						int count = folders.Length;

						// DataGridView に追加していく
						for (int i = 0; i < count; i++)
						{
							dataGridViewResult.Rows.Add(folders[i], null, null, null, null);
						}
					}
				}
				catch (System.UnauthorizedAccessException)
				{
					MessageBox.Show("アクセスできないフォルダがあります");
				}
			}
			else
			{
				MessageBox.Show(textBoxPath.Text +
					" は存在しないフォルダです");
			}
		}

		// Copy Button の挙動
		private void buttonCopy_Click(object sender, EventArgs e)
		{
			// DataGridViewの内容をクリップボードにTSV形式でコピー
			// 全選択
			dataGridViewResult.SelectAll();
			// 内容をクリップボードへコピー
			dataGridViewResult.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			Clipboard.SetDataObject(dataGridViewResult.GetClipboardContent());
			// クリップボードから取得してコピーし直す（Exelにペースト時に折り返さない対策）
			Clipboard.SetText(Clipboard.GetText());
		}

		// Clear Button の挙動
		private void buttonClear_Click(object sender, EventArgs e)
		{
			// 全ての行の内容をクリア
			dataGridViewResult.Rows.Clear();
		}
	}
}
