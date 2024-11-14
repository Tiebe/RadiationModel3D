using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium140";
        public override double halfLife { get; } = 889.2d;
        public override double atomicWeight { get; } = 139.91899d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2756000.0), new Promethium140() } },

        };
    }
}
    
    