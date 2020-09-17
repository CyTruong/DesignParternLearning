using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartern.SingletonDemo
{
    public class LazyInstance
    {
        private static LazyInstance __instance;
        private int Count;

        private LazyInstance()
        {
            Count = 0;
        }

        public static LazyInstance GetInstance()
        {
            if (__instance == null)
            {
                __instance = new LazyInstance();
            }
            return __instance;
        }

        public int GetCount()
        {
            return Count;
        }

        public void IncCount()
        {
            Count++;
        }

    }

}
