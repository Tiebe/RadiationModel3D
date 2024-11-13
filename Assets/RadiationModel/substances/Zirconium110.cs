
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium110";
        public override double halfLife { get; } = 0.0375d;
        public override double atomicWeight { get; } = 109.95467d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium110() } },

        };
    }
}
    
    