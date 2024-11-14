using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium180m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium180m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 179.95089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01425), new Rhenium180() } },

        };
    }
}
    
    