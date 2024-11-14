using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine118 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine118";
        public override double halfLife { get; } = 822.0d;
        public override double atomicWeight { get; } = 117.91307d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6720000.0), new Tellurium118() } },

        };
    }
}
    
    