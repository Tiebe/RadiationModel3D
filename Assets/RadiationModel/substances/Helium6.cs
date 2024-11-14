using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium6 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium6";
        public override double halfLife { get; } = 0.80692d;
        public override double atomicWeight { get; } = 6.01889d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3505219.6), new Lithium6() } },

        };
    }
}
    
    