using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine38m : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine38m";
        public override double halfLife { get; } = 0.715d;
        public override double atomicWeight { get; } = 37.96873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((671370.0, 0.00185)), new Chlorine38() } },

        };
    }
}
    
    