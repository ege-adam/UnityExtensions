using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public static class MathfExtensions
    {
        public static float Map(float x, float in_min, float in_max, float out_min, float out_max, bool clamp = false)
        {
            if (clamp) x = Mathf.Max(in_min, Mathf.Min(x, in_max));
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
    }
}
