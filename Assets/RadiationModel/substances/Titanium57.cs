using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium57";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 56.96307d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10040000.0), new Vanadium57() } },

        };
    }
}
    
    