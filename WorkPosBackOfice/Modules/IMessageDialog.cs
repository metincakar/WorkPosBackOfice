using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkPosBackOfice.Modules
{
    public interface IMessageDialog
    {
        void ErrorMesaj(string message,string title);
        void InformationMesaj(string message, string title);

        void WarningMesaj(string message, string title);

        DialogResult WarnigMesaj(string message, string title);
    }
}
