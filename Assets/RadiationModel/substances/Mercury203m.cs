using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury203m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury203m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 202.97387d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury203() }, { 0.52740381d, new GammaParticle(341500.0, 0.00363) }, { 0.98213d, new GammaParticle(591400.0, 0.0021) }, { 0.1397945103548878d, new GammaParticle(11777.0, 0.10528) }, { 0.10583707897143353d, new GammaParticle(68894.0, 0.018) }, { 0.17941528898361342d, new GammaParticle(70820.0, 0.01751) }, { 0.06088913654724901d, new GammaParticle(80316.0, 0.01544) }, { 0.07872965355559297d, new GammaParticle(81285.0, 0.01525) }, { 0.017840517008343965d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    