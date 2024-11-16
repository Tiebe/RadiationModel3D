using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium154m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 153.96778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2720000.0, 0.00046)), new Hafnium154() } },

        };
    }
}
    
    