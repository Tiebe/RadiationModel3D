using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium102";
        public override double halfLife { get; } = 17884800.0d;
        public override double atomicWeight { get; } = 101.90683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new List<RadioactiveSubstance> { new BetaParticle(1, 2323400.0), new Ruthenium102() } },
            { 0.22d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1120000.0), new Palladium102() } },

        };
    }
}
    
    