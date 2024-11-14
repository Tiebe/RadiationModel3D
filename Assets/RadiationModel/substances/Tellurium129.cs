using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium129";
        public override double halfLife { get; } = 4176.0d;
        public override double atomicWeight { get; } = 128.9066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1502100.0), new Iodine129() } },

        };
    }
}
    
    