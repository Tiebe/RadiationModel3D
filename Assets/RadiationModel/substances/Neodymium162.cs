
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium162";
        public override double halfLife { get; } = 0.31d;
        public override double atomicWeight { get; } = 161.95812d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium162() } },

        };
    }
}
    
    