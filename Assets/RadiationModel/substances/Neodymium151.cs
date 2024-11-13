
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium151";
        public override double halfLife { get; } = 746.4d;
        public override double atomicWeight { get; } = 150.92384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium151() } },

        };
    }
}
    
    