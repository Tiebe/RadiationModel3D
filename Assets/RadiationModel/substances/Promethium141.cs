using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium141";
        public override double halfLife { get; } = 1254.0d;
        public override double atomicWeight { get; } = 140.91355d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3669000.0), new Neodymium141() } },

        };
    }
}
    
    