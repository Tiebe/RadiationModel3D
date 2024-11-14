using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium99m";
        public override double halfLife { get; } = 16920.0d;
        public override double atomicWeight { get; } = 98.90819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2104400.0), new Ruthenium99() } },

        };
    }
}
    
    