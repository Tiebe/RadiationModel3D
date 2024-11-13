
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron52 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron52";
        public override double halfLife { get; } = 29790.0d;
        public override double atomicWeight { get; } = 51.94811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese52() } },

        };
    }
}
    
    