
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium132";
        public override double halfLife { get; } = 6.2d;
        public override double atomicWeight { get; } = 131.93384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium132() } },

        };
    }
}
    
    