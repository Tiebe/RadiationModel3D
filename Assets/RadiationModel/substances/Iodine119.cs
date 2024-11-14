using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine119 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine119";
        public override double halfLife { get; } = 1146.0d;
        public override double atomicWeight { get; } = 118.91006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3405000.0), new Tellurium119() } },
            { 0.51d, new List<RadioactiveSubstance> { new BetaParticle(1, 3405000.0), new Tellurium119() } },
            { 0.49d, new List<RadioactiveSubstance> { new Tellurium119() } },

        };
    }
}
    
    