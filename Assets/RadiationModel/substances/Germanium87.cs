using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium87";
        public override double halfLife { get; } = 0.103d;
        public override double atomicWeight { get; } = 86.9532d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12027900.0), new Arsenic87() } },

        };
    }
}
    
    