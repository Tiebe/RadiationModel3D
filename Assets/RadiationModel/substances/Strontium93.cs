
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium93";
        public override double halfLife { get; } = 445.8d;
        public override double atomicWeight { get; } = 92.91402d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium93() } },

        };
    }
}
    
    