using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic66 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic66";
        public override double halfLife { get; } = 0.09577d;
        public override double atomicWeight { get; } = 65.94415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9582000.0), new Germanium66() } },

        };
    }
}
    
    