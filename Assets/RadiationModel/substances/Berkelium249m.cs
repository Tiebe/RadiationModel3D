using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium249m";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 249.07499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((8799.99998, 0.14089)), new Berkelium249() } },

        };
    }
}
    
    