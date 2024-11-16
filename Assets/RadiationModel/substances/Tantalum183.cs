using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum183 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum183";
        public override double halfLife { get; } = 440640.0d;
        public override double atomicWeight { get; } = 182.95138d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1072200.0), new Tungsten183() } },

        };
    }
}
    
    