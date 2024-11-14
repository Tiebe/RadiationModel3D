using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium77";
        public override double halfLife { get; } = 40359.6d;
        public override double atomicWeight { get; } = 76.92355d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2703430.0), new Arsenic77() } },

        };
    }
}
    
    