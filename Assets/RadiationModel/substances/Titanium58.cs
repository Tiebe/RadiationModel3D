
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium58";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 57.96681d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium58() } },

        };
    }
}
    
    