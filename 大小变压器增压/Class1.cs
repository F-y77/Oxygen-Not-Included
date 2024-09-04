using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变压器功率提升
{

    public class Patches
    {
        [HarmonyPatch(typeof(PowerTransformerSmallConfig))]
        [HarmonyPatch("CreateBuildingDef")]
        public class Patch_a
        {

            public static void Postfix(ref BuildingDef __result)
            {
                __result.GeneratorWattageRating = 2500f;
                __result.GeneratorBaseCapacity = 2500f;
            }
        }

        [HarmonyPatch(typeof(PowerTransformerConfig))]
        [HarmonyPatch("CreateBuildingDef")]
        public class Patch_b
        {

            public static void Postfix(ref BuildingDef __result)
            {
                __result.GeneratorWattageRating = 10000f;
                __result.GeneratorBaseCapacity = 10000f;
            }
        }
        public static void Prefix()
        {
            Strings.Add(new string[]
            {
        "STRINGS.BUILDINGS.PREFABS.POWERTRANSFORMERSMALL.EFFECT",
        "限制小型电压器的电压为2500F"
            });
            Strings.Add(new string[]
            {
        "STRINGS.BUILDINGS.PREFABS.POWERTRANSFORMER.EFFECT",
        "限制大型电压器的电压为10000F"
            });
        }
    }
}



