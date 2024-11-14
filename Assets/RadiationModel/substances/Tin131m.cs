using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin131m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin131m";
        public override double halfLife { get; } = 58.4d;
        public override double atomicWeight { get; } = 130.91712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4781400.0), new Antimony131() } },

        };
    }
}
    
    