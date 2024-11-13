
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium103";
        public override double halfLife { get; } = 0.239d;
        public override double atomicWeight { get; } = 102.93724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium103() } },

        };
    }
}
    
    