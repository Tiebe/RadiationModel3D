using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus32 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus32";
        public override double halfLife { get; } = 1232755.2d;
        public override double atomicWeight { get; } = 31.97391d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur32() }, { 1.0d, new BetaParticle(-1, 855328.55) } } },

        };
    }
}
    