
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt66 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt66";
        public override double halfLife { get; } = 0.194d;
        public override double atomicWeight { get; } = 65.93944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel66() } },

        };
    }
}
    
    