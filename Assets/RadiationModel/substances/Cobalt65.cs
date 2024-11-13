
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt65 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt65";
        public override double halfLife { get; } = 1.16d;
        public override double atomicWeight { get; } = 64.93646d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel65() } },

        };
    }
}
    
    