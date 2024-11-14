using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum182m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum182m";
        public override double halfLife { get; } = 0.283d;
        public override double atomicWeight { get; } = 181.95017d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.07606), new Tantalum182() } },

        };
    }
}
    
    