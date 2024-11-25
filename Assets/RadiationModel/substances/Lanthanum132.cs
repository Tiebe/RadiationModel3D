using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum132 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum132";
        public override double halfLife { get; } = 17280.0d;
        public override double atomicWeight { get; } = 131.91012d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium132() }, { 1.0d, new BetaParticle(1, 1716350.0) } } },

        };
    }
}
    