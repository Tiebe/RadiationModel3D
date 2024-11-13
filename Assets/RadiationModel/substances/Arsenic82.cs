
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic82 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic82";
        public override double halfLife { get; } = 19.1d;
        public override double atomicWeight { get; } = 81.92474d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium82() } },

        };
    }
}
    
    