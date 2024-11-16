using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur35 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur35";
        public override double halfLife { get; } = 7548768.0d;
        public override double atomicWeight { get; } = 34.96903d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 167320.0), new Chlorine35() } },

        };
    }
}
    
    