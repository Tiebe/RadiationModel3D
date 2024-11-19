using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium87m";
        public override double halfLife { get; } = 10098.0d;
        public override double atomicWeight { get; } = 86.90929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new List<RadioactiveSubstance> { new GammaParticle(0.00319, 388529.0), new Strontium87() } },
            { 0.003d, new List<RadioactiveSubstance> { new Rubidium87() } },

        };
    }
}
    
    