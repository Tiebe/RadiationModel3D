
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium65";
        public override double halfLife { get; } = 0.0275d;
        public override double atomicWeight { get; } = 64.96961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese65() } },

        };
    }
}
    
    