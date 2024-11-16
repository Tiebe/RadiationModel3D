using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium112";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 111.91441d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6591000.0), new Palladium112() } },

        };
    }
}
    
    