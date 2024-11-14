using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium183m : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium183m";
        public override double halfLife { get; } = 35640.0d;
        public override double atomicWeight { get; } = 182.95331d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new List<RadioactiveSubstance> { new BetaParticle(1, 2320000.0), new Rhenium183() } },
            { 0.15d, new List<RadioactiveSubstance> { new GammaParticle(0.00729), new Osmium183() } },

        };
    }
}
    
    