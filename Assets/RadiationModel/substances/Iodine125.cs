using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine125 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine125";
        public override double halfLife { get; } = 5132764.8d;
        public override double atomicWeight { get; } = 124.90463d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium125() }, { 0.0668d, new GammaParticle(35492.5, 0.03493) }, { 0.1476624243368d, new GammaParticle(4135.0, 0.29984) }, { 0.39430950437074697d, new GammaParticle(27202.0, 0.04558) }, { 0.7342821310442216d, new GammaParticle(27473.0, 0.04513) }, { 0.210138754794603d, new GammaParticle(31093.0, 0.03988) }, { 0.25573886458503187d, new GammaParticle(31359.0, 0.03954) }, { 0.045600109790428854d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    