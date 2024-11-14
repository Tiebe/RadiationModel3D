using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium63";
        public override double halfLife { get; } = 0.0132d;
        public override double atomicWeight { get; } = 62.98191d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 16650000.0), new Arsenic63() } },
            { 0.005d, new List<RadioactiveSubstance> { new ProtonParticle(), new Germanium61() } },

        };
    }
}
    
    