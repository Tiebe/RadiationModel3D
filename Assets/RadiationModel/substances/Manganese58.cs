
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese58 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese58";
        public override double halfLife { get; } = 3.0d;
        public override double atomicWeight { get; } = 57.94007d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron58() } },

        };
    }
}
    
    