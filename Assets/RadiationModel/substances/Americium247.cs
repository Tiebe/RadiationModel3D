using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium247";
        public override double halfLife { get; } = 1380.0d;
        public override double atomicWeight { get; } = 247.07209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1617000.0), new Curium247() } },

        };
    }
}
    
    