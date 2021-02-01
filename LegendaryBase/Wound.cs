﻿using System;
using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;

namespace LegendaryHeroes
{
    public class Wound : DefaultBadCard
    {
        public override void Healing(GameEngine game, Player player)
        {
            foreach (ICard card in player.Hand)
            {
                if (card is Wound)
                {
                    if (player.Hand.Remove(card))
                    {
                        game.Board.KOPile.Add(card);
                    }
                }
            }
        }

        public override bool HealingCondition(GameEngine game, Player player)
        {
            bool truth = base.HealingCondition(game, player);
            throw new NotImplementedException();
        }
    }
}
