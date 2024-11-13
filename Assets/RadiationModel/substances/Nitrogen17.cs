
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen17 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen17";
        public override double halfLife { get; } = 4.173d;
        public override double atomicWeight { get; } = 17.00845d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Oxygen17() } },

        };
    }
}
    
    