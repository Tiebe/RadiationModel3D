using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper78 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper78";
        public override double halfLife { get; } = 0.3307d;
        public override double atomicWeight { get; } = 77.95192d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12694200.0), new Zinc78() } },

        };
    }
}
    
    