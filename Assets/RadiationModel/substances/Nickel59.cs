
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel59 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel59";
        public override double halfLife { get; } = 2556113112000.0d;
        public override double atomicWeight { get; } = 58.93435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt59() } },

        };
    }
}
    
    