using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon20 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon20";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 20.04026d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 15730000.0), new Nitrogen20() } },

        };
    }
}
    
    