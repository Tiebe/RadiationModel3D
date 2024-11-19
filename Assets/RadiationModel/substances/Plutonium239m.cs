using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium239m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium239m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 239.05258d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00317, 391600.0), new Plutonium239() } },

        };
    }
}
    
    