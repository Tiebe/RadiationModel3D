using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium161";
        public override double halfLife { get; } = 0.215d;
        public override double atomicWeight { get; } = 160.95466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7857000.0), new Promethium161() } },

        };
    }
}
    
    