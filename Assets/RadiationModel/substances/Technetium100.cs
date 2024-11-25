using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium100";
        public override double halfLife { get; } = 15.65d;
        public override double atomicWeight { get; } = 99.90765d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999974d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium100() }, { 1.0d, new BetaParticle(-1, 1603200.0) }, { 0.000304d, new GammaParticle(378700.0, 0.00327) }, { 6.6e-06d, new GammaParticle(499800.0, 0.00248) }, { 0.066d, new GammaParticle(539520.0, 0.0023) }, { 0.0537d, new GammaParticle(590770.0, 0.0021) }, { 0.00038899999999999997d, new GammaParticle(689200.0, 0.0018) }, { 0.000112d, new GammaParticle(734800.0, 0.00169) }, { 1.32e-05d, new GammaParticle(736900.0, 0.00168) }, { 0.000693d, new GammaParticle(822600.0, 0.00151) }, { 0.000356d, new GammaParticle(1024900.0, 0.00121) }, { 0.000356d, new GammaParticle(1201500.0, 0.00103) }, { 0.0001d, new GammaParticle(1325800.0, 0.00094) }, { 0.00066d, new GammaParticle(1362200.0, 0.00091) }, { 0.0032d, new GammaParticle(1512100.0, 0.00082) }, { 7.3e-05d, new GammaParticle(1558900.0, 0.0008) }, { 1.3e-05d, new GammaParticle(1701000.0, 0.00073) }, { 0.00027d, new GammaParticle(1847600.0, 0.00067) }, { 9.2e-05d, new GammaParticle(1864900.0, 0.00066) }, { 1.3e-05d, new GammaParticle(1875000.0, 0.00066) }, { 3.3e-05d, new GammaParticle(2121200.0, 0.00058) }, { 1.3e-05d, new GammaParticle(2127700.0, 0.00058) }, { 6e-05d, new GammaParticle(2298400.0, 0.00054) }, { 1.3e-05d, new GammaParticle(2659500.0, 0.00047) }, { 2.0726359973778e-05d, new GammaParticle(2737.0, 0.45299) }, { 9.302092915142328e-05d, new GammaParticle(19150.0, 0.06474) }, { 0.0001765103019951106d, new GammaParticle(19279.0, 0.06431) }, { 4.7434713226735084e-05d, new GammaParticle(21736.0, 0.05704) }, { 5.5119136769466173e-05d, new GammaParticle(21875.0, 0.05668) }, { 7.684423542731084e-06d, new GammaParticle(22072.0, 0.05617) } } },
            { 2.6e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum100() }, { 9.8560113522e-07d, new GammaParticle(2440.0, 0.50813) }, { 4.839850774954199e-06d, new GammaParticle(17374.0, 0.07136) }, { 9.224034257583761e-06d, new GammaParticle(17479.0, 0.07093) }, { 2.4203531780433612e-06d, new GammaParticle(19681.0, 0.063) }, { 2.7930875674620386e-06d, new GammaParticle(19794.0, 0.06264) }, { 3.7273438941867765e-07d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    