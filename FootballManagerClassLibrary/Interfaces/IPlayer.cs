﻿using FootballManagerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerClassLibrary.Interfaces
{
    public interface IPlayer
    {
        List<Player> GetPlayers();
        Player GetPlayer(int id);
    }
}
