﻿using System.Linq;
using TheFipster.Minecraft.Speedrun.Domain;

namespace TheFipster.Minecraft.Speedrun.Services
{
    public class ValidityChecker : IValidityChecker
    {
        public ValidityResult Check(RunInfo run)
        {
            var result = new ValidityResult();

            if (run.Players.Count() == 0)
            {
                result.IsValid = false;
                result.Reasons.Add("There were no players participating.");
            }

            if (run.World.Dimensions.Count() == 0)
            {
                result.IsValid = false;
                result.Reasons.Add("The server generated no dimensions.");
            }

            return result;
        }
    }
}