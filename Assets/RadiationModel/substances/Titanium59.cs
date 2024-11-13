
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium59";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 58.97222d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium59() } },

        };
    }
}
    
    