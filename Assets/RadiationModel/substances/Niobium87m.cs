using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium87m";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 86.9207d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5477000.0), new Zirconium87() } },

        };
    }
}
    
    