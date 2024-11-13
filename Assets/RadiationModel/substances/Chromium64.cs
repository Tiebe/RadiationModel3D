
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium64";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 63.96389d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese64() } },

        };
    }
}
    
    