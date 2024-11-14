using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium139";
        public override double halfLife { get; } = 249.0d;
        public override double atomicWeight { get; } = 138.9168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4516000.0), new Neodymium139() } },

        };
    }
}
    
    