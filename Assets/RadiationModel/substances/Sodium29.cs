using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium29 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium29";
        public override double halfLife { get; } = 0.0432d;
        public override double atomicWeight { get; } = 29.00288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13292400.0), new Magnesium29() } },

        };
    }
}
    
    