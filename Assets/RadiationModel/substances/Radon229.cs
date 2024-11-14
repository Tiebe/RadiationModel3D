using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon229 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon229";
        public override double halfLife { get; } = 11.9d;
        public override double atomicWeight { get; } = 229.04226d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3694000.0), new Francium229() } },

        };
    }
}
    
    