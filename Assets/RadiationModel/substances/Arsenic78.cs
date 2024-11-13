
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic78 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic78";
        public override double halfLife { get; } = 5442.0d;
        public override double atomicWeight { get; } = 77.92183d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium78() } },

        };
    }
}
    
    