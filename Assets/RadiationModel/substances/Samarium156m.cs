using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium156m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 155.92704d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00089), new Samarium156() } },

        };
    }
}
    
    