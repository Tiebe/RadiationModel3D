
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium52";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 51.94688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Vanadium52() } },

        };
    }
}
    
    