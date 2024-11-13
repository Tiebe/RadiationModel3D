
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium99";
        public override double halfLife { get; } = 0.2692d;
        public override double atomicWeight { get; } = 98.93288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium99() } },

        };
    }
}
    
    