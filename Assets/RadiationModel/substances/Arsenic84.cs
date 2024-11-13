
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic84 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic84";
        public override double halfLife { get; } = 3.16d;
        public override double atomicWeight { get; } = 83.9293d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium84() } },

        };
    }
}
    
    