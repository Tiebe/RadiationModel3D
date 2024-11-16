using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium86m";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 85.92595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8989000.0), new Zirconium86() } },

        };
    }
}
    
    