
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen19 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen19";
        public override double halfLife { get; } = 0.336d;
        public override double atomicWeight { get; } = 19.01702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen19() } },

        };
    }
}
    
    