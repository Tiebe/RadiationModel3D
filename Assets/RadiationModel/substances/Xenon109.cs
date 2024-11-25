using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon109 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon109";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 108.95043d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium105() }, { 1.0d, new AlphaParticle(5237002.09) }, { 0.23d, new GammaParticle(150000.0, 0.00827) }, { 0.0055364105d, new GammaParticle(4135.0, 0.29984) }, { 0.014330896370955639d, new GammaParticle(27202.0, 0.04558) }, { 0.02668695786025259d, new GammaParticle(27473.0, 0.04513) }, { 0.00763734245586835d, new GammaParticle(31093.0, 0.03988) }, { 0.009294645768791783d, new GammaParticle(31359.0, 0.03954) }, { 0.001657303312923432d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    