using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper77 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper77";
        public override double halfLife { get; } = 0.4703d;
        public override double atomicWeight { get; } = 76.94754d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9926400.0), new Zinc77() } },

        };
    }
}
    
    