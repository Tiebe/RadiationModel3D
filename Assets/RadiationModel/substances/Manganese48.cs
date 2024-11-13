
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese48 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese48";
        public override double halfLife { get; } = 0.1581d;
        public override double atomicWeight { get; } = 47.96855d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium48() } },

        };
    }
}
    
    