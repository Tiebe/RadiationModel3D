
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium159";
        public override double halfLife { get; } = 0.134d;
        public override double atomicWeight { get; } = 158.95623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium159() } },

        };
    }
}
    
    