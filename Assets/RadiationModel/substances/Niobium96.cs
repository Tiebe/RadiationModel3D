
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium96";
        public override double halfLife { get; } = 84060.0d;
        public override double atomicWeight { get; } = 95.9081d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum96() } },

        };
    }
}
    
    