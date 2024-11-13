
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium74 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium74";
        public override double halfLife { get; } = 0.0276d;
        public override double atomicWeight { get; } = 73.95617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium74() } },

        };
    }
}
    
    