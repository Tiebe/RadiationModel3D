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

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Xenon111() } },
            { 0.0026d, new List<RadioactiveSubstance> { new AlphaParticle(4945047.4), new Iodine108() } },

        };
    }
}
    
    