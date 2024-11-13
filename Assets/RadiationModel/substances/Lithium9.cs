
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium9 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium9";
        public override double halfLife { get; } = 0.1782d;
        public override double atomicWeight { get; } = 9.02679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Beryllium9() } },

        };
    }
}
    
    