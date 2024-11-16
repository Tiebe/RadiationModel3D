using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon129m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon129m";
        public override double halfLife { get; } = 767232.0d;
        public override double atomicWeight { get; } = 128.90503d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00525), new Xenon129() } },

        };
    }
}
    
    