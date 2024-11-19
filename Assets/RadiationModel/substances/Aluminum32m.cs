using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum32m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum32m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 31.98911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0013, 957000.0), new Aluminum32() } },

        };
    }
}
    
    