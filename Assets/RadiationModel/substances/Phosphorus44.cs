
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus44 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus44";
        public override double halfLife { get; } = 0.0185d;
        public override double atomicWeight { get; } = 44.01193d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur44() } },

        };
    }
}
    
    