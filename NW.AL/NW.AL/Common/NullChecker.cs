using System;


namespace NW.AL.Common
{
    public static class NullChecker
    {
        public static bool IsObjectInitialized(object obj)
        {
            if(obj == null)
            {
                throw new NullReferenceException($"Null reference to {nameof(obj)}"); 
            }
            return true;
        }
    }
}
