﻿using Legendary.Controls;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legendary
{
    public partial class BystanderCard : CardControl
    {
        private readonly Bystander Bystander;

        private BystanderCard() : base()
        {
            tableLayoutPanel.Controls.Remove(labelRules);
            labelRules = new FormattedLabel
            {
                AutoSize = true,
                Location = new Point(58, 127),
                MaximumSize = new Size(165, int.MaxValue),
                Name = "labelRules",
                Padding = new Padding(0),
                TabIndex = 6
            };
            labelRules.Click += ctl_Click;
            tableLayoutPanel.Controls.Add(labelRules, 1, 3);
        }

        public BystanderCard(Bystander bystander) : this()
        {
            Bystander = bystander;
            UpdateLabels();
        }

        public override void UpdateLabels()
        {
            labelAttack.Text = "";
            labelClasses.Text = "";
            labelCost.Text = "";
            labelFlavor.Text = Bystander.FlavorText;
            labelRecruit.Text = Bystander.PrintedVictoryPoints.ToString();
            labelRules.Text = Bystander.RulesText;
            labelSubtitle.Text = Bystander.Subtitle;
            labelTeams.Text = "";
            labelTitle.Text = Bystander.Title;
        }
    }
}
