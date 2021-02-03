﻿using System;
using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;

namespace LegendaryHeroes
{
    public static class StackCards
    {
        public static BadCard CreateWound()
        {
            return new BadCard
            {
                ID = "Wound",
                Healing = WoundHealing,
                HealingCondition = WoundHealingCondition,
                RulesText = "<b>Healing:</b> If you don't recruit any Heroes or defeat any Villains on your turn, you may KO all the Wounds from your hand.",
                Title = "Wound"
            };
        }

        private static void WoundHealing(BadCard card, GameEngine game, Player player)
        {
            foreach (ICard handCard in player.Hand)
            {
                if (handCard.ID.StartsWith("Wound"))
                {
                    // @TODO
                }
            }
        }

        private static bool WoundHealingCondition(BadCard card, GameEngine game, Player player)
        {
            bool truth = BadCard.DefaultHealingCondition(card, game, player);
            throw new NotImplementedException();
        }
    }
}
