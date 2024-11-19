using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth190p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth190p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.98905d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00313, 396000.0), new Bismuth190() } },

        };
    }
}
    
    