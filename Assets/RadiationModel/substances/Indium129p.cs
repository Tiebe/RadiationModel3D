using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium129p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium129p";
        public override double halfLife { get; } = 0.67d;
        public override double atomicWeight { get; } = 128.92359d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9411000.0), new Tin129() } },

        };
    }
}
    
    