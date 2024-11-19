using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium206m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium206m";
        public override double halfLife { get; } = 224.4d;
        public override double atomicWeight { get; } = 205.97895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2643100.00002, 0.00047)), new Thallium206() } },

        };
    }
}
    
    