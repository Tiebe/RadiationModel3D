
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium54";
        public override double halfLife { get; } = 49.8d;
        public override double atomicWeight { get; } = 53.94643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium54() } },

        };
    }
}
    
    