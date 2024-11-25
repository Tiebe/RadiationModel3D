using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium100";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 99.91801d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium100() }, { 1.0d, new BetaParticle(-1, 1709000.0) }, { 0.0026d, new GammaParticle(33010.0, 0.03756) }, { 0.0079d, new GammaParticle(103720.0, 0.01195) }, { 0.0019d, new GammaParticle(253400.0, 0.00489) }, { 0.0021d, new GammaParticle(303200.0, 0.00409) }, { 0.193d, new GammaParticle(400500.0, 0.0031) }, { 0.034d, new GammaParticle(471480.0, 0.00263) }, { 0.0074d, new GammaParticle(498050.0, 0.00249) }, { 0.3d, new GammaParticle(504270.0, 0.00246) }, { 0.0038d, new GammaParticle(703700.0, 0.00176) }, { 0.00040082444869500003d, new GammaParticle(2299.0, 0.5393) }, { 0.002045130384122182d, new GammaParticle(16521.0, 0.07505) }, { 0.0039059021851072994d, new GammaParticle(16615.0, 0.07462) }, { 0.001010640574583059d, new GammaParticle(18694.0, 0.06632) }, { 0.0011622366607705178d, new GammaParticle(18795.0, 0.06597) }, { 0.00015159608618745885d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    