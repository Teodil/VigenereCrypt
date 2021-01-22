using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigenereCipher;
using FileManager;

namespace VigenereForm.Controllers
{
    public class VigenereFormPresenter
    {
        private IVignereForm vignereForm;
        private Encryption encryption = new Encryption();
        private Decryption decryption = new Decryption();
        private FileManager.FileManager fileManager = new FileManager.FileManager();

        public VigenereFormPresenter(IVignereForm vignereForm)
        {
            this.vignereForm = vignereForm;
            vignereForm.saveToFileEvent += new Action<string, string>(saveToFile);
            vignereForm.LoadFromFileEvent += new Func<string, string>(loadFromFile);
            vignereForm.CryptEvent += new Func<string, string, string>(crypt);
            vignereForm.DecryptEvent += new Func<string, string, string>(decrypt);

        }

        private string decrypt(string message, string key)
        {
            if (decryption.Decrypt(message, key, out string _message))
                MessageServise.ShowMessage("Сообщение расшифровано");
            else
                MessageServise.ShowError("Ошибка при расшифровке данных");

            return _message;
        }

        private string crypt(string message, string key)
        {
            if (encryption.Encrypt(message, key, out string Cipher))
                MessageServise.ShowMessage("Сообщение зашифровано");
            else
                MessageServise.ShowError("Ошибка при зашифровании данных");

            return Cipher;
        }

        private string loadFromFile(string path)
        {
            try
            {
                return fileManager.LoadFileText(path);
            }
            catch(Exception ex)
            {
                MessageServise.ShowError(ex.ToString());
                return "";
            }
        }

        private void saveToFile(string path, string message)
        {
            try
            {
                fileManager.SaveTextToFile(path, message);
                MessageServise.ShowMessage("Файл успешно сохранён");
            }
            catch (Exception ex)
            {
                MessageServise.ShowError(ex.ToString());
            }
        }
    }
}
