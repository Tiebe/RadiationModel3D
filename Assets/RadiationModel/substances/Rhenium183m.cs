using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium183m";
        public override double halfLife { get; } = 0.00104d;
        public override double atomicWeight { get; } = 182.95287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1907000.0, 0.00065)), new Rhenium183() } },

        };
    }
}
    
    