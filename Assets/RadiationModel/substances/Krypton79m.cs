using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton79m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton79m";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 78.92022d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00954), new Krypton79() } },

        };
    }
}
    
    