using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead199m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead199m";
        public override double halfLife { get; } = 732.0d;
        public override double atomicWeight { get; } = 198.97337d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((429000.0, 0.00289)), new Lead199() } },

        };
    }
}
    
    