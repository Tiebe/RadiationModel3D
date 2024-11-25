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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur33() }, { 1.0d, new BetaParticle(-1, 124229.15) } } },

        };
    }
}
    