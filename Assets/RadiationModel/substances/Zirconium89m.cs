using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium89m";
        public override double halfLife { get; } = 249.66d;
        public override double atomicWeight { get; } = 88.90951d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9377d, new List<RadioactiveSubstance> { new GammaParticle(0.00211), new Zirconium89() } },
            { 0.0623d, new List<RadioactiveSubstance> { new BetaParticle(1, 3421000.0), new Yttrium89() } },

        };
    }
}
    
    