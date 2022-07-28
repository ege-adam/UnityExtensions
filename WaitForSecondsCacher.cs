using UnityEngine;
using System.Collections.Generic;

namespace Utils
{
    public static class WaitForSecondsCacher
    {
        private static Dictionary<float, WaitForSeconds> cache = new Dictionary<float, WaitForSeconds>();

        public static WaitForSeconds WaitForSeconds(float seconds)
        {
            if(cache.ContainsKey(seconds)) return cache[seconds];
            else
            {
                cache.Add(seconds, new WaitForSeconds(seconds));
                return cache[seconds];
            }
        }
    }
}