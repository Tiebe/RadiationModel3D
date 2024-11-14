using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium136n : RadioactiveSubstance
    {
        public override string name { get; } = "Barium136n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 135.90818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00037), new Barium136() } },

        };
    }
}
    
    