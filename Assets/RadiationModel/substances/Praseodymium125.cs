
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium125";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 124.93766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium125() } },

        };
    }
}
    
    