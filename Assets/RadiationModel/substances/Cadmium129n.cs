using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium129n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium129n";
        public override double halfLife { get; } = 0.0036d;
        public override double atomicWeight { get; } = 128.93469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00054), new Cadmium129() } },

        };
    }
}
    
    