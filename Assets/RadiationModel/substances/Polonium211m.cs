using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium211m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211m";
        public override double halfLife { get; } = 25.2d;
        public override double atomicWeight { get; } = 210.98822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99984d, new List<RadioactiveSubstance> { new AlphaParticle(10079002.09), new Lead207() } },
            { 0.00016d, new List<RadioactiveSubstance> { new GammaParticle((1462500.0, 0.00085)), new Polonium211() } },

        };
    }
}
    
    