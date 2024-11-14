using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium137";
        public override double halfLife { get; } = 2.49d;
        public override double atomicWeight { get; } = 136.9256d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7052200.0), new Iodine137() } },

        };
    }
}
    
    