using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium114";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 113.93709d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium114() }, { 1.0d, new BetaParticle(-1, 5810500.0) }, { 0.06849999999999999d, new GammaParticle(227600.0, 0.00545) }, { 0.111d, new GammaParticle(265100.0, 0.00468) }, { 0.0009d, new GammaParticle(265100.0, 0.00468) }, { 0.1918d, new GammaParticle(265100.0, 0.00468) }, { 0.8083d, new GammaParticle(265100.0, 0.00468) }, { 0.045d, new GammaParticle(298000.0, 0.00416) }, { 0.1918d, new GammaParticle(298000.0, 0.00416) }, { 0.3973d, new GammaParticle(443000.0, 0.0028) }, { 0.1233d, new GammaParticle(518700.0, 0.00239) }, { 0.13699999999999998d, new GammaParticle(544000.0, 0.00228) }, { 0.06849999999999999d, new GammaParticle(563400.0, 0.0022) }, { 0.0015d, new GammaParticle(563400.0, 0.0022) }, { 0.3151d, new GammaParticle(563400.0, 0.0022) }, { 0.015d, new GammaParticle(563400.0, 0.0022) }, { 0.13699999999999998d, new GammaParticle(590600.0, 0.0021) }, { 0.0274d, new GammaParticle(773900.0, 0.0016) }, { 0.0548d, new GammaParticle(870300.0, 0.00142) }, { 0.0027d, new GammaParticle(1054200.0, 0.00118) }, { 0.012d, new GammaParticle(1320200.0, 0.00094) }, { 0.041100000000000005d, new GammaParticle(1360500.0, 0.00091) }, { 0.0054d, new GammaParticle(1618700.0, 0.00077) }, { 0.0002584085499d, new GammaParticle(2737.0, 0.45299) }, { 0.00225213473205d, new GammaParticle(2737.0, 0.45299) }, { 0.0011441067232977843d, new GammaParticle(19150.0, 0.06474) }, { 0.009962753423724557d, new GammaParticle(19150.0, 0.06474) }, { 0.0021709804996162888d, new GammaParticle(19279.0, 0.06431) }, { 0.018904655452987775d, new GammaParticle(19279.0, 0.06431) }, { 0.00058342111625295d, new GammaParticle(21736.0, 0.05704) }, { 0.005080365847923987d, new GammaParticle(21736.0, 0.05704) }, { 0.0006779353370859278d, new GammaParticle(21875.0, 0.05668) }, { 0.0059033851152876715d, new GammaParticle(21875.0, 0.05668) }, { 9.45142208329779e-05d, new GammaParticle(22072.0, 0.05617) }, { 0.0008230192673636859d, new GammaParticle(22072.0, 0.05617) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    