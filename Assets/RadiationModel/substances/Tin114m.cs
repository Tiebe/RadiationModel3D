using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin114m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin114m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 113.90609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0004), new Tin114() } },

        };
    }
}
    
    