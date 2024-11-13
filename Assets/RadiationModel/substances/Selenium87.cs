
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium87";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 86.92869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine87() } },

        };
    }
}
    
    