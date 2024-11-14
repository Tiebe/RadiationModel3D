using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine115 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine115";
        public override double halfLife { get; } = 78.0d;
        public override double atomicWeight { get; } = 114.91805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5725000.0), new Tellurium115() } },

        };
    }
}
    
    