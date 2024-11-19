using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium243m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 243.06148d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01419, 87400.0), new Curium243() } },

        };
    }
}
    
    