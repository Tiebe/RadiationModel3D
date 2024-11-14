using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium152";
        public override double halfLife { get; } = 3.03d;
        public override double atomicWeight { get; } = 151.95033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5450000.0), new Thulium152() } },

        };
    }
}
    
    