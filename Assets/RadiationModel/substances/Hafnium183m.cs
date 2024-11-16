using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium183m";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 182.9551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1460000.0, 0.00085)), new Hafnium183() } },

        };
    }
}
    
    