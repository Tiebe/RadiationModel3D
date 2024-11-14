using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium106";
        public override double halfLife { get; } = 30.07d;
        public override double atomicWeight { get; } = 105.90729d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3544500.0), new Palladium106() } },

        };
    }
}
    
    