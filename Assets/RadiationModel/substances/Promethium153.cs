using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium153";
        public override double halfLife { get; } = 315.0d;
        public override double atomicWeight { get; } = 152.92416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1912100.0), new Samarium153() } },

        };
    }
}
    
    