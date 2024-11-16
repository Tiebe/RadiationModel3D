using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium137";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 136.93543d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7846000.0), new Samarium137() } },

        };
    }
}
    
    