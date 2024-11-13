
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium79";
        public override double halfLife { get; } = 14.8d;
        public override double atomicWeight { get; } = 78.93795d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium79() } },

        };
    }
}
    
    