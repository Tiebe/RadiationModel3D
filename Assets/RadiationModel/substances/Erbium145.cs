
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium145";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 144.95787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium145() } },

        };
    }
}
    
    