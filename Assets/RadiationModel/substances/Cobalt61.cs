
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt61 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt61";
        public override double halfLife { get; } = 5936.4d;
        public override double atomicWeight { get; } = 60.93248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel61() } },

        };
    }
}
    
    