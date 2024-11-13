
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium96";
        public override double halfLife { get; } = 1.059d;
        public override double atomicWeight { get; } = 95.92172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium96() } },

        };
    }
}
    
    