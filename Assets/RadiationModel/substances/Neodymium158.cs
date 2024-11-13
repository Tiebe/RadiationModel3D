
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium158";
        public override double halfLife { get; } = 0.81d;
        public override double atomicWeight { get; } = 157.94221d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium158() } },

        };
    }
}
    
    