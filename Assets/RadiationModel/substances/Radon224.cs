using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon224 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon224";
        public override double halfLife { get; } = 6420.0d;
        public override double atomicWeight { get; } = 224.0241d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 696000.0), new Francium224() } },

        };
    }
}
    
    