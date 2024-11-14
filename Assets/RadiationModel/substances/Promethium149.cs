using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium149";
        public override double halfLife { get; } = 191088.0d;
        public override double atomicWeight { get; } = 148.91834d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1071500.0), new Samarium149() } },

        };
    }
}
    
    