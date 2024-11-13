
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium100";
        public override double halfLife { get; } = 0.2021d;
        public override double atomicWeight { get; } = 99.93578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium100() } },

        };
    }
}
    
    