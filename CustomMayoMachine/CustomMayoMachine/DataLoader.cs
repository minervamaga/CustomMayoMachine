using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewValley;

namespace CustomMayoMachine
{
    internal class DataLoader
    {
        public static IModHelper Helper;
        public static ITranslationHelper I18N;
        public static Dictionary<int, int> MayoData;

        public DataLoader(IModHelper helper)
        {
            Helper = helper;

            MayoData = DataLoader.Helper.Data.ReadJsonFile<Dictionary<int, int>>("data\\MayoData.json") ?? new Dictionary<int, int>() { { 74, 20160 } };
            DataLoader.Helper.Data.WriteJsonFile("data\\MayoData.json", MayoData);

        }
    }
}