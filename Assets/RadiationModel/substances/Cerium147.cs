
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium147";
        public override double halfLife { get; } = 56.4d;
        public override double atomicWeight { get; } = 146.92269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium147() } },

        };
    }
}
    
    