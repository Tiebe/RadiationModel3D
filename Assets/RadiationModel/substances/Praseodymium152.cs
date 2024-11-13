
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium152";
        public override double halfLife { get; } = 3.57d;
        public override double atomicWeight { get; } = 151.93155d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium152() } },

        };
    }
}
    
    