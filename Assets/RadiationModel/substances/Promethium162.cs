
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium162";
        public override double halfLife { get; } = 0.63d;
        public override double atomicWeight { get; } = 161.95057d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium162() } },

        };
    }
}
    
    