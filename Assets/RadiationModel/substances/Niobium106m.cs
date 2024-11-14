using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium106m";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 105.92904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10028000.0), new Molybdenum106() } },

        };
    }
}
    
    