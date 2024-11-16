using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium83";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 82.93815d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8302000.0), new Zirconium83() } },

        };
    }
}
    
    