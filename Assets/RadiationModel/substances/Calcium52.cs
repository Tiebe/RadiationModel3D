
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium52";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 51.96321d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium52() } },

        };
    }
}
    
    