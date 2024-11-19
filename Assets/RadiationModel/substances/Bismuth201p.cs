using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth201p : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 200.97915d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2012000.0, 0.00062)), new Bismuth201() } },

        };
    }
}
    
    