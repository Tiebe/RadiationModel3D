using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium140";
        public override double halfLife { get; } = 9.2d;
        public override double atomicWeight { get; } = 139.91604d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6045000.0), new Neodymium140() } },

        };
    }
}
    
    