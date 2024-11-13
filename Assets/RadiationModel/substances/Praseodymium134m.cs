
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium134m";
        public override double halfLife { get; } = 660.0d;
        public override double atomicWeight { get; } = 133.91577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium134() } },

        };
    }
}
    
    