using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium102m";
        public override double halfLife { get; } = 1.31d;
        public override double atomicWeight { get; } = 101.91819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7357000.0), new Molybdenum102() } },

        };
    }
}
    
    