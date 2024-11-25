using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum126 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum126";
        public override double halfLife { get; } = 54.0d;
        public override double atomicWeight { get; } = 125.91952d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium126() }, { 1.0d, new BetaParticle(1, 4690500.0) } } },

        };
    }
}
    