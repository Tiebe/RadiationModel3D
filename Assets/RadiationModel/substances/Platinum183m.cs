using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum183m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum183m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 182.96163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 4464000.0), new Iridium183() } },
            { 0.031d, new List<RadioactiveSubstance> { new GammaParticle((35000.0, 0.03542)), new Platinum183() } },

        };
    }
}
    
    