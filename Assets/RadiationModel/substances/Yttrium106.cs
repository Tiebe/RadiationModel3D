
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium106";
        public override double halfLife { get; } = 0.075d;
        public override double atomicWeight { get; } = 105.95084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium106() } },

        };
    }
}
    
    