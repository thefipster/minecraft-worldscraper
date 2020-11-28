﻿using System.Collections.Generic;
using TheFipster.Minecraft.Domain;

namespace TheFipster.Minecraft.Services.Abstractions
{
    public interface IPlayerStore
    {
        IEnumerable<Player> GetPlayers();

        Player GetPlayerByName(string name);

        Player GetPlayerById(string id);
    }
}