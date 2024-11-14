using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90";
        public override double halfLife { get; } = 52560.0d;
        public override double atomicWeight { get; } = 89.91126d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6110550.0), new Zirconium90() } },

        };
    }
}
    
    