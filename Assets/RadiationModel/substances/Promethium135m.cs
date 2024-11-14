using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium135m";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 134.92503d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6384000.0), new Neodymium135() } },

        };
    }
}
    
    