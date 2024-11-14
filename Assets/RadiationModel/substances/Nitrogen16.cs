using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen16 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen16";
        public override double halfLife { get; } = 7.13d;
        public override double atomicWeight { get; } = 16.0061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10420902.1), new Oxygen16() } },

        };
    }
}
    
    