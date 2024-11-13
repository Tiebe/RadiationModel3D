
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium242";
        public override double halfLife { get; } = 1008.0d;
        public override double atomicWeight { get; } = 242.06293d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neptunium242() } },

        };
    }
}
    
    