using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium118";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 117.92656d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine118() }, { 1.0d, new BetaParticle(1, 6281000.0) } } },
            { 0.00042d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine117() }, { 1.0d, new ProtonParticle() } } },
            { 2.3999999999999997e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium114() }, { 1.0d, new AlphaParticle(12078002.09) } } },

        };
    }
}
    