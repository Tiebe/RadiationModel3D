
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium136";
        public override double halfLife { get; } = 107.0d;
        public override double atomicWeight { get; } = 135.9236d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium136() } },

        };
    }
}
    
    