using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium225";
        public override double halfLife { get; } = 0.062d;
        public override double atomicWeight { get; } = 225.02939d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9027047.4), new Thorium221() } },

        };
    }
}
    
    