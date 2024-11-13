
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum125 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum125";
        public override double halfLife { get; } = 64.8d;
        public override double atomicWeight { get; } = 124.92082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium125() } },

        };
    }
}
    
    