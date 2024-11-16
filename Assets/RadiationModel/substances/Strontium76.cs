using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium76";
        public override double halfLife { get; } = 7.89d;
        public override double atomicWeight { get; } = 75.94176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6229100.0), new Rubidium76() } },

        };
    }
}
    
    