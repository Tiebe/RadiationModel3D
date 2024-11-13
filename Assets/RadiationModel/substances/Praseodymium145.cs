
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium145";
        public override double halfLife { get; } = 21542.4d;
        public override double atomicWeight { get; } = 144.91452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium145() } },

        };
    }
}
    
    