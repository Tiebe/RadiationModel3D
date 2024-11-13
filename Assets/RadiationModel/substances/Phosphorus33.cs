
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus33 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus33";
        public override double halfLife { get; } = 2190240.0d;
        public override double atomicWeight { get; } = 32.97173d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur33() } },

        };
    }
}
    
    