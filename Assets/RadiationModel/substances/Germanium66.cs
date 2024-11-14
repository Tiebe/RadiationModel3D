using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium66";
        public override double halfLife { get; } = 8136.0d;
        public override double atomicWeight { get; } = 65.93386d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2116700.0), new Gallium66() } },

        };
    }
}
    
    