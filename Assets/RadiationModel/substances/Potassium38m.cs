using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium38m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium38m";
        public override double halfLife { get; } = 0.92435d;
        public override double atomicWeight { get; } = 37.96922d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99967d, new List<RadioactiveSubstance> { new BetaParticle(1, 6044220.0), new Argon38() } },
            { 0.00033d, new List<RadioactiveSubstance> { new GammaParticle(0.00953), new Potassium38() } },

        };
    }
}
    
    