
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium115";
        public override double halfLife { get; } = 1.3916615832e+22d;
        public override double atomicWeight { get; } = 114.90388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin115() } },

        };
    }
}
    
    