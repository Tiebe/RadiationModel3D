
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium146";
        public override double halfLife { get; } = 2.15d;
        public override double atomicWeight { get; } = 145.93036d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum146() } },

        };
    }
}
    
    