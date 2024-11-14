using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130m";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 129.92502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10292200.0), new Tin130() } },

        };
    }
}
    
    