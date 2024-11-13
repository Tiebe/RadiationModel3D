
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic82m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic82m";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 81.92488d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium82() } },

        };
    }
}
    
    