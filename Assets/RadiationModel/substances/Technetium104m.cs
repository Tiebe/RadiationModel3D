using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium104m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium104m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 103.91151d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01771), new Technetium104() } },

        };
    }
}
    
    