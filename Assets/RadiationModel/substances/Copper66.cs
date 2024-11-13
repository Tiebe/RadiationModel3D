
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper66 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper66";
        public override double halfLife { get; } = 307.2d;
        public override double atomicWeight { get; } = 65.92887d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc66() } },

        };
    }
}
    
    