using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon17 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon17";
        public override double halfLife { get; } = 0.193d;
        public override double atomicWeight { get; } = 17.02258d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13162000.0), new Nitrogen17() } },

        };
    }
}
    
    