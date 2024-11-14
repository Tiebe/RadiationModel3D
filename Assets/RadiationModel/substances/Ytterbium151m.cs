using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 150.9562d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9972000.0), new Thulium151() } },

        };
    }
}
    
    