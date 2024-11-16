using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver119 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver119";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 118.91557d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5334000.0), new Cadmium119() } },

        };
    }
}
    
    