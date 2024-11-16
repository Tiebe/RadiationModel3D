using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium165";
        public override double halfLife { get; } = 594.0d;
        public override double atomicWeight { get; } = 164.93527d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2635000.0), new Thulium165() } },

        };
    }
}
    
    