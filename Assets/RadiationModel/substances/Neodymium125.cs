
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium125";
        public override double halfLife { get; } = 0.65d;
        public override double atomicWeight { get; } = 124.94839d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium125() } },

        };
    }
}
    
    