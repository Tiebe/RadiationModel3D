
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper70 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper70";
        public override double halfLife { get; } = 44.5d;
        public override double atomicWeight { get; } = 69.93239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc70() } },

        };
    }
}
    
    