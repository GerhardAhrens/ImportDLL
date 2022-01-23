//-----------------------------------------------------------------------
// <copyright file="MyBeep.cs" company="Lifeprojects.de">
//     Class: MyBeep
//     Copyright © Lifeprojects.de 2022
// </copyright>
//
// <author>Gerhard Ahrens - Lifeprojects.de</author>
// <email>gerhard.ahrens@lifeprojects.de</email>
// <date>22.02.2022</date>
//
// <summary>
// Klasse für 
// </summary>
//-----------------------------------------------------------------------


namespace ImportDLL.Core
{
    using System;
    using System.Runtime.InteropServices;

    public class MyBeep
    {
        private delegate int BeepDelegate(int frequenz, int dauer);

        private static BeepDelegate internalBeep;

        static MyBeep()
        {
            try
            {
                internalBeep = DLLFunctionLoader.LoadFunction<BeepDelegate>("kernel32", "Beep");
            }
            catch (Exception ex)
            {
                string errText = ex.Message;
                throw ex;
            }
        }

        public void Play(int frequenz, int dauer = 400)
        {
            internalBeep(frequenz, dauer);
        }
    }
}