using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.FMP.MOD.File.LIB.MVCS
{
    public static class Utility
    {
        public static string StorageToString(ulong _size)
        {
            if (_size < 1024L)
                return string.Format("{0}M", _size);
            if (_size < 1024L * 1024)
                return string.Format("{0}G", _size / 1024);
            return string.Format("{0}T", _size / 1024 / 1024);
        }
    }
}
