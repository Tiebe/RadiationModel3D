using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium147";
        public override double halfLife { get; } = 803.4d;
        public override double atomicWeight { get; } = 146.91901d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2702800.0), new Neodymium147() } },

        };
    }
}
    
    