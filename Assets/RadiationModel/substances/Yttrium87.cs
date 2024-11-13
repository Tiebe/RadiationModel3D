
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium87";
        public override double halfLife { get; } = 287280.0d;
        public override double atomicWeight { get; } = 86.91088d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium87() } },

        };
    }
}
    
    