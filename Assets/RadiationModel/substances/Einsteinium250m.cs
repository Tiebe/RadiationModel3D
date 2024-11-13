
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium250m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium250m";
        public override double halfLife { get; } = 7992.0d;
        public override double atomicWeight { get; } = 250.07883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Californium250() } },

        };
    }
}
    
    