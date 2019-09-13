
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley;
using StardewValley.Objects;
using SObject = StardewValley.Object;


namespace CustomMayoMachine

{
    internal class ObjectOverrides
    {

        public virtual bool PerformObjectDropInAction(ref SObject __instance, ref Item dropInItem, ref bool probe, ref Farmer who, ref bool __result)
        {
            if (dropInItem is SObject object1)
            {
                    if (__instance.Name.Equals("Mayonnaise Machine"))
                    {
                        if (object1 == null && (object1.Category == -5))
                        {}
                        if ((__instance.heldObject.Value == null || __instance.heldObject.Value.ParentSheetIndex != object1.ParentSheetIndex)
                             && (__instance.heldObject.Value == null || __instance.MinutesUntilReady > 0))
                        {
                            int minutesUntilReady = 0;

                            Item currentObject = __instance.heldObject.Value;

                            if (DataLoader.MayoData.ContainsKey(object1.ParentSheetIndex))
                            {
                                minutesUntilReady = DataLoader.MayoData[object1.ParentSheetIndex];
                            }
                            else
                            {
                                return true;
                            }

                        if (__instance.bigCraftable.Value && !probe &&
                            (object1 != null && __instance.heldObject.Value == null))
                                {
                                    __instance.scale.X = 5f;
                                }

                            __result = true;
                            return false;
                        }
                    }
            }

            return true;
        }

        public static bool PerformRemoveAction(ref Object __instance, ref Vector2 tileLocation)
        {
            if (__instance.Name == "Mayonnaise Machine")
            {
                if (__instance.heldObject.Value != null)
                {
                    Game1.createItemDebris(__instance.heldObject.Value.getOne(), tileLocation * 64f, (Game1.player.FacingDirection + 2) % 4, (GameLocation)null, -1);
                }

            }

            return true;
        }
    }
}