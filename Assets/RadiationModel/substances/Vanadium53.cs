
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium53 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium53";
        public override double halfLife { get; } = 92.58d;
        public override double atomicWeight { get; } = 52.94433d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium53() } },

        };
    }
}
    
    