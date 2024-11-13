
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium74";
        public override double halfLife { get; } = 0.06478d;
        public override double atomicWeight { get; } = 73.94427d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton74() } },

        };
    }
}
    
    