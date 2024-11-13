
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth204n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204n";
        public override double halfLife { get; } = 0.00107d;
        public override double atomicWeight { get; } = 203.98088d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Bismuth204() } },

        };
    }
}
    
    