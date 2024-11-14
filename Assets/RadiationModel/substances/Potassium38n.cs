using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium38n : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium38n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 37.97279d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00036), new Potassium38() } },

        };
    }
}
    
    