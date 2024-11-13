
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium84";
        public override double halfLife { get; } = 195.6d;
        public override double atomicWeight { get; } = 83.91847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine84() } },

        };
    }
}
    
    