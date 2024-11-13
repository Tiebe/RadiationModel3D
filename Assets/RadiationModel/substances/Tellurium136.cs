
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium136";
        public override double halfLife { get; } = 17.63d;
        public override double atomicWeight { get; } = 135.9201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine136() } },

        };
    }
}
    
    