using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony139 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony139";
        public override double halfLife { get; } = 0.182d;
        public override double atomicWeight { get; } = 138.94627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10155000.0), new Tellurium139() } },

        };
    }
}
    
    