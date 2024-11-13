
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium97n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium97n";
        public override double halfLife { get; } = 3.86d;
        public override double atomicWeight { get; } = 96.93762d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver97() } },

        };
    }
}
    
    