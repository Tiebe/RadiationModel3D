using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium94m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 93.91288d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium94() }, { 0.85d, new GammaParticle(432200.0, 0.00287) }, { 0.85d, new GammaParticle(769900.0, 0.00161) }, { 0.15d, new GammaParticle(1202400.0, 0.00103) }, { 7.733098703e-05d, new GammaParticle(2027.0, 0.61166) }, { 0.00046315840456404814d, new GammaParticle(14883.0, 0.08331) }, { 0.0008881273337757395d, new GammaParticle(14958.0, 0.08289) }, { 0.00022299776947294565d, new GammaParticle(16803.0, 0.07379) }, { 0.00025377146166021214d, new GammaParticle(16880.0, 0.07345) }, { 3.07736921872665e-05d, new GammaParticle(17011.0, 0.07288) } } },

        };
    }
}
    