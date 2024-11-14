using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt76m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt76m";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 75.97256d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 16630000.0), new Nickel76() } },

        };
    }
}
    
    