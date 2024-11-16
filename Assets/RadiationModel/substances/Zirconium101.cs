using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium101";
        public override double halfLife { get; } = 2.29d;
        public override double atomicWeight { get; } = 100.92146d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5730000.0), new Niobium101() } },

        };
    }
}
    
    