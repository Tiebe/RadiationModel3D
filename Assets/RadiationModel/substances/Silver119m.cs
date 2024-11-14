using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver119m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver119m";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 118.91559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5354000.0), new Cadmium119() } },

        };
    }
}
    
    