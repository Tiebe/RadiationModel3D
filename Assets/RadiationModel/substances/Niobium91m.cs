using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91m";
        public override double halfLife { get; } = 5258304.0d;
        public override double atomicWeight { get; } = 90.9071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.966d, new List<RadioactiveSubstance> { new GammaParticle(0.01185, 104600.0), new Niobium91() } },
            { 0.034d, new List<RadioactiveSubstance> { new Zirconium91() } },
            { 2.8e-05d, new List<RadioactiveSubstance> { new BetaParticle(1, 1362190.0), new Zirconium91() } },

        };
    }
}
    
    