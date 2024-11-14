using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium160";
        public override double halfLife { get; } = 288.0d;
        public override double atomicWeight { get; } = 159.93756d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2137000.0), new Thulium160() } },

        };
    }
}
    
    