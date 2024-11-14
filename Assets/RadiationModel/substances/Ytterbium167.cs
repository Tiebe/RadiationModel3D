using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium167";
        public override double halfLife { get; } = 1050.0d;
        public override double atomicWeight { get; } = 166.93495d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1953100.0), new Thulium167() } },

        };
    }
}
    
    