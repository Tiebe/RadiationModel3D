using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium86m";
        public override double halfLife { get; } = 2844.0d;
        public override double atomicWeight { get; } = 85.91512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9931d, new List<RadioactiveSubstance> { new GammaParticle(0.00569, 218000.0), new Yttrium86() } },
            { 0.0069d, new List<RadioactiveSubstance> { new BetaParticle(1, 5458100.0), new Strontium86() } },

        };
    }
}
    
    