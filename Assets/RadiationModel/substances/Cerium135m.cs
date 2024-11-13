
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium135m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 134.90964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cerium135() } },

        };
    }
}
    
    