using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth189m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth189m";
        public override double halfLife { get; } = 0.005d;
        public override double atomicWeight { get; } = 188.98939d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new AlphaParticle(8472047.4), new Thallium185() } },
            { 0.17d, new List<RadioactiveSubstance> { new GammaParticle(0.00674, 184000.0), new Bismuth189() } },

        };
    }
}
    
    