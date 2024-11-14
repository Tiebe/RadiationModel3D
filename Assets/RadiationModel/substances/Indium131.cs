using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium131";
        public override double halfLife { get; } = 0.2615d;
        public override double atomicWeight { get; } = 130.92697d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9240600.0), new Tin131() } },

        };
    }
}
    
    