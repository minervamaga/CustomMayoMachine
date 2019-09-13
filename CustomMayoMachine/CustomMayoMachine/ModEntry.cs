using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Buildings;
using StardewValley.Locations;
using StardewValley.Objects;
using SObject = StardewValley.Object;

namespace CustomMayoMachine
{
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used by SMAPI.")]
    internal class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            ItemEvents.ActiveItemChanged += this.MoreEvents_ActiveItemChanged;
            helper.Events.Player.Warped += this.OnWarped;
            helper.Events.Display.MenuChanged += this.OnMenuChanged;
            helper.Events.GameLoop.Saving += this.OnSaving;
            helper.Events.GameLoop.Saved += this.OnSaved;
            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
        }


        /*********
        ** Protected methods
        *********/
        private void RestoreVanillaObjects()
        {
            
        }

        private void InitSpecialObject(Item i)
        {
           
        }

        private void MoreEvents_ActiveItemChanged(object s, EventArgsActiveItemChanged e)
        {
            
        }

        /// <summary>Raised after a player warps to a new location.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnWarped(object sender, WarpedEventArgs e)
        {
            this.TriggerItemChangedEvent();
        }

        /// <summary>Raised after a game menu is opened, closed, or replaced.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnMenuChanged(object sender, MenuChangedEventArgs e)
        {
            this.TriggerItemChangedEvent();
        }

        private void TriggerItemChangedEvent()
        {
            this.MoreEvents_ActiveItemChanged(null, new EventArgsActiveItemChanged(Game1.player.CurrentItem, Game1.player.CurrentItem));
        }

        /// <summary>Raised before the game begins writes data to the save file (except the initial save creation).</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnSaving(object sender, SavingEventArgs e)
        {
            
        }

        /// <summary>Raised after the game finishes writing data to the save file (except the initial save creation).</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnSaved(object sender, SavedEventArgs e)
        {
            
        }

        /// <summary>Raised after the player loads a save slot and the world is initialised.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnSaveLoaded(object sender, EventArgs e)
        {
            
        }

        private void IterateFurniture(Action<GameLocation> handler)
        {
            foreach (GameLocation loc in Game1.locations)
            {
                
            }
        }

        private void SleepFurniture(GameLocation loc)
        {
            
        }

        private void WakeupFurniture(GameLocation loc)
        {
            
        }
    }
}