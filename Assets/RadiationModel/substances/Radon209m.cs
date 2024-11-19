using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon209m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon209m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 208.99166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00106, 1174000.0), new Radon209() } },

        };
    }
}
    
    