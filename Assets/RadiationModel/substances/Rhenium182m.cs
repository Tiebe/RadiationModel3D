using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium182m";
        public override double halfLife { get; } = 50904.0d;
        public override double atomicWeight { get; } = 181.95128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2860100.0), new Tungsten182() } },

        };
    }
}
    
    