using BepInEx;
using HarmonyLib;
//using System.IO;

namespace EdoAkse.Cheat.CrewRarity
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Main : BaseUnityPlugin
    {
        public const string pluginGuid = "edoakse.starvalor.crewrarity";
        public const string pluginName = "EdoAkse Cheat: Crew Rarity";
        public const string pluginVersion = "1.0.0";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(Main));
        }

        [HarmonyPatch(typeof(CrewMember))]
        [HarmonyPatch("GainXP")]
        [HarmonyPrefix]
        private static void EverevolvingPre(ref bool ___everEvolving, ref int ___nextRarityCount)
        {
            ___everEvolving = true;
            ___nextRarityCount = 9001;
        }
    }
}