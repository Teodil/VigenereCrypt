using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VigenereCipher;

namespace VigenereForm
{
    public partial class VigenereForm : Form,IVignereForm
    {
        public event Action<string, string> saveToFileEvent;
        public event Func<string, string> LoadFromFileEvent;
        public event Func<string,string, string> CryptEvent;
        public event Func<string, string, string> DecryptEvent;

        public VigenereForm()
        {
            InitializeComponent();
        }

        private void CipherBTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CryptMessageBox.Text))
            {
                MessageServise.ShowExclamation("Введите сообщение");
                return;
            }
            if (String.IsNullOrEmpty(CryptKeyBox.Text))
            {
                MessageServise.ShowExclamation("Введите ключ");
                return;
            }
            CryptCipherBox.Text = CryptEvent?.Invoke(CryptMessageBox.Text, CryptKeyBox.Text);
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            TextBox KeyBox = sender as TextBox;
            KeyBox.Text = KeyBox.Text.ToLower();
            if (!String.IsNullOrEmpty(KeyBox.Text))
            {
                var lastChar = KeyBox.Text.Last();
                if (lastChar < 97 || lastChar > 122)
                {
                    KeyBox.Text = KeyBox.Text.Remove(KeyBox.Text.Length - 1);
                }
            }

            KeyBox.SelectionStart = KeyBox.Text.Length;
        }

        private void LoadMessageFromFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы|*.*|Текстовые файлы|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CryptMessageBox.Text = LoadFromFileEvent?.Invoke(openFileDialog.FileName);
            }
        }

        private void LoadCipherFromFileBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы|*.*|Текстовые файлы|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DecryptCipherBox.Text = LoadFromFileEvent?.Invoke(openFileDialog.FileName);
            }
        }

        private void SaveCipherToFileBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveToFileEvent?.Invoke(saveFileDialog.FileName,CryptCipherBox.Text);
            }
        }

        private void SaveMessageFromFileBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveToFileEvent?.Invoke(saveFileDialog.FileName, DecryptMessageBox.Text);
            }
        }

        private void DecryptBTN_Click(object sender, EventArgs e)
        {
            DecryptMessageBox.Text = DecryptEvent?.Invoke(DecryptCipherBox.Text, DecryptKeyBox.Text);
        }
    }
}
