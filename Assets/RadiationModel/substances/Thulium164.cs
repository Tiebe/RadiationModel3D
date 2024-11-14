using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium164";
        public override double halfLife { get; } = 120.0d;
        public override double atomicWeight { get; } = 163.93354d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4033600.0), new Erbium164() } },
            { 0.61d, new List<RadioactiveSubstance> { new Erbium164() } },
            { 0.39d, new List<RadioactiveSubstance> { new BetaParticle(1, 4033600.0), new Erbium164() } },

        };
    }
}
    
    