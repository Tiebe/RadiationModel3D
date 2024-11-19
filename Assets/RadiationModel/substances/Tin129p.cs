using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin129p : RadioactiveSubstance
    {
        public override string name { get; } = "Tin129p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.91542d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00069, 1803000.0), new Tin129() } },

        };
    }
}
    
    