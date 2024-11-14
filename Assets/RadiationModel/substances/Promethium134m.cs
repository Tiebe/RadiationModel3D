using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium134m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 133.92838d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8936000.0), new Neodymium134() } },

        };
    }
}
    
    