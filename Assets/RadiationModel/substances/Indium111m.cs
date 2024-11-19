using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium111m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium111m";
        public override double halfLife { get; } = 462.0d;
        public override double atomicWeight { get; } = 110.90568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00231, 537000.0), new Indium111() } },

        };
    }
}
    
    