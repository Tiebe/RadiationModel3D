
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium81";
        public override double halfLife { get; } = 1107.0d;
        public override double atomicWeight { get; } = 80.91799d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bromine81() } },

        };
    }
}
    
    