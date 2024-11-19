using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium207m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium207m";
        public override double halfLife { get; } = 1.33d;
        public override double atomicWeight { get; } = 206.97887d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00092, 1348000.0), new Thallium207() } },

        };
    }
}
    
    