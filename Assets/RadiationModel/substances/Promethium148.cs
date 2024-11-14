using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium148";
        public override double halfLife { get; } = 463795.2d;
        public override double atomicWeight { get; } = 147.91748d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2470100.0), new Samarium148() } },

        };
    }
}
    
    