
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium250";
        public override double halfLife { get; } = 30960.0d;
        public override double atomicWeight { get; } = 250.07862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Californium250() } },

        };
    }
}
    
    