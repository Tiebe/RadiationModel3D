using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium229m : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium229m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 229.03176d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((0.0, 123984198405.50366)), new Thorium229() } },

        };
    }
}
    
    