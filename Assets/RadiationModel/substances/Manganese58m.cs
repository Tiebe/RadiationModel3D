
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese58m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese58m";
        public override double halfLife { get; } = 65.4d;
        public override double atomicWeight { get; } = 57.94014d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron58() } },

        };
    }
}
    
    