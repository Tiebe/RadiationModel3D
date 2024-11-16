using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium151m";
        public override double halfLife { get; } = 6.6d;
        public override double atomicWeight { get; } = 150.94559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7587000.0), new Erbium151() } },

        };
    }
}
    
    