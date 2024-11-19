using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium165m";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 164.93253d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01542, 80400.0), new Thulium165() } },

        };
    }
}
    
    