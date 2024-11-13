
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium90";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 89.9401d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine90() } },

        };
    }
}
    
    