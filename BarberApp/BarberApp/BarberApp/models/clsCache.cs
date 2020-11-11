using System;
using System.Collections.Generic;
using System.Text;

namespace BarberApp.models
{
    public class clsCache
    {
        private string strname;
        private bool blnIniSesio;

        public clsCache()
        {
            strname = "";
            blnIniSesio = false;
        }

        public string Name { get => strname; set => strname = value; }
        public bool IniSesion1 { get => blnIniSesio; set => blnIniSesio = value; }
    }
}
