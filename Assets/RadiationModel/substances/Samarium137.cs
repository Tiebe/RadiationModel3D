
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium137";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 136.92701d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Promethium137() } },

        };
    }
}
    
    