using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium132";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 131.9408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6490000.0), new Promethium132() } },

        };
    }
}
    
    