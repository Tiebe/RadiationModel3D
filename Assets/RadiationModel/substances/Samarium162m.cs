using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium162m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 161.9427d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00123, 1009000.0), new Samarium162() } },

        };
    }
}
    
    