using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium251m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 251.0808d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.03444, 36000.0), new Berkelium251() } },

        };
    }
}
    
    