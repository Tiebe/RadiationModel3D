using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 122.90804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2152700.0, 0.00058)), new Tin123() } },

        };
    }
}
    
    