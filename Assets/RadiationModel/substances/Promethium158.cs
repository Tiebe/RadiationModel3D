using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium158";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 157.93655d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6145900.0), new Samarium158() } },

        };
    }
}
    
    