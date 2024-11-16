using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium181m";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 180.94975d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((595300.00001, 0.00208)), new Hafnium181() } },

        };
    }
}
    
    