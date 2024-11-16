using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium131";
        public override double halfLife { get; } = 1500.0d;
        public override double atomicWeight { get; } = 130.90852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2231680.0), new Iodine131() } },

        };
    }
}
    
    