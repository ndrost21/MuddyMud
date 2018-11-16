﻿using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuddyMud
{
    public partial class MuddyMud : Form
    {
        private Player _player;

        public MuddyMud()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");

            _player = new Player(0, 0, 1, 10, 10);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void MuddyMud_Load(object sender, EventArgs e)
        {

        }

    }
}
