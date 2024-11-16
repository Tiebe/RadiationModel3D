using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium138";
        public override double halfLife { get; } = 4.7d;
        public override double atomicWeight { get; } = 137.94025d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6090000.0), new Europium138() } },

        };
    }
}
    
    