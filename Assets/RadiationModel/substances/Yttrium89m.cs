
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium89m";
        public override double halfLife { get; } = 15.663d;
        public override double atomicWeight { get; } = 88.90681d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Yttrium89() } },

        };
    }
}
    
    