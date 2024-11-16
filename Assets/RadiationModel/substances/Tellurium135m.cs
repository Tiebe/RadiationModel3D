using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium135m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 134.91822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0008), new Tellurium135() } },

        };
    }
}
    
    