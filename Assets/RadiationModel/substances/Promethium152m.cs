using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium152m";
        public override double halfLife { get; } = 451.2d;
        public override double atomicWeight { get; } = 151.92366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3653000.0), new Samarium152() } },

        };
    }
}
    
    