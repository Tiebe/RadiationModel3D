
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium157";
        public override double halfLife { get; } = 0.307d;
        public override double atomicWeight { get; } = 156.948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium157() } },

        };
    }
}
    
    