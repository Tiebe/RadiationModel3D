using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium116n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116n";
        public override double halfLife { get; } = 2.18d;
        public override double atomicWeight { get; } = 115.90557d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium116() }, { 0.37200000000000005d, new GammaParticle(162390.0, 0.00763) }, { 0.04014007488d, new GammaParticle(3571.0, 0.3472) }, { 0.10393921315233046d, new GammaParticle(24001.0, 0.05166) }, { 0.19500790460099524d, new GammaParticle(24209.0, 0.05121) }, { 0.05471485903081876d, new GammaParticle(27367.0, 0.0453) }, { 0.06511068224667432d, new GammaParticle(27581.0, 0.04495) }, { 0.010395823215855565d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    