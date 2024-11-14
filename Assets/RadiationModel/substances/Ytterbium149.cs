using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium149";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 148.96422d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10610000.0), new Thulium149() } },

        };
    }
}
    
    