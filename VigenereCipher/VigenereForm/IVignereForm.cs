using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereForm
{
    public interface IVignereForm
    {
        event Action<string, string> saveToFileEvent;
        event Func<string, string> LoadFromFileEvent;

        event Func<string,string, string> CryptEvent;
        event Func<string, string, string> DecryptEvent;
    }
}
