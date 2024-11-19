using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese51i : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese51i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 50.95299d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00028, 4450600.0), new Manganese51() } },

        };
    }
}
    
    