using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium109m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 108.91343d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01292), new Ruthenium109() } },

        };
    }
}
    
    