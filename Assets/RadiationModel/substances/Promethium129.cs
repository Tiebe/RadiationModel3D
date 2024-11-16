using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium129";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 128.94291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9200000.0), new Neodymium129() } },

        };
    }
}
    
    