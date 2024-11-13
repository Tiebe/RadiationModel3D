
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin130m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin130m";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 129.91606d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony130() } },

        };
    }
}
    
    