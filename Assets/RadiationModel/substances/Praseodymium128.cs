
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium128";
        public override double halfLife { get; } = 2.85d;
        public override double atomicWeight { get; } = 127.92879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium128() } },

        };
    }
}
    
    