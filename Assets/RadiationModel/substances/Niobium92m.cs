using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium92m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92m";
        public override double halfLife { get; } = 874022.4d;
        public override double atomicWeight { get; } = 91.90733d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2141220.0), new Zirconium92() } },

        };
    }
}
    
    