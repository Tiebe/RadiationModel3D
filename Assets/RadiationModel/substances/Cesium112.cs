using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium112";
        public override double halfLife { get; } = 0.00049d;
        public override double atomicWeight { get; } = 111.95017d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon111() }, { 1.0d, new ProtonParticle() } } },
            { 0.0026d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine108() }, { 1.0d, new AlphaParticle(4947002.09) } } },

        };
    }
}
    