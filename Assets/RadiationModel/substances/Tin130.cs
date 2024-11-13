
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin130 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin130";
        public override double halfLife { get; } = 223.2d;
        public override double atomicWeight { get; } = 129.91397d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony130() } },

        };
    }
}
    
    