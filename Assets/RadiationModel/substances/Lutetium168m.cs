
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium168m";
        public override double halfLife { get; } = 402.0d;
        public override double atomicWeight { get; } = 167.93891d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ytterbium168() } },

        };
    }
}
    
    