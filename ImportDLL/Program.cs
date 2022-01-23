using System;

using ImportDLL.Core;

namespace DelegateImportDLL
{
    public class Program
    {

        private static void Main(string[] args)
        {

            uint pMsgTyp = (uint)MsgOptions.MB_OK | (uint)MsgOptions.MB_ICONASTERISK;
            int result = SystemMessageBox.Show("MsgBox Text\nÜber ein Delegate aufgerufenen Win32 API Funktion", "Titel", pMsgTyp);

            MyBeep beep = new MyBeep();
            for (int i = 0; i < 3; i++)
            {
                beep.Play(500);
                beep.Play(1000);
            }

        }
    }
}
