using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon212p : RadioactiveSubstance
    {
        public override string name { get; } = "Radon212p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 211.99733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0002), new Radon212() } },

        };
    }
}
    
    