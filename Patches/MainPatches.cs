using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Il2Cpp;
using HarmonyLib;
using AdjustableWalkSpeed;


namespace AdjustableWalkSpeed.Patches
{
    internal class MainPatches
    {

        [HarmonyPatch(typeof(vp_FPSController), nameof(vp_FPSController.GetSlopeMultiplier))]

        public class MovementSpeedModifier
        {
            public static void Postfix(ref float __result)
            {

                //get value
                float val = Main.walkSpeedMultiplier;

                __result *= val;
               
            }
        }


    }
}
