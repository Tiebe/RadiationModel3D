
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine75 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine75";
        public override double halfLife { get; } = 5802.0d;
        public override double atomicWeight { get; } = 74.92581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Selenium75() } },

        };
    }
}
    
    