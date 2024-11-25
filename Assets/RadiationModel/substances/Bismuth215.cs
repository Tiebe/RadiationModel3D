using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth215 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth215";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 215.00175d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium215() }, { 1.0d, new BetaParticle(-1, 1085400.00001) }, { 0.04031d, new GammaParticle(271100.0, 0.00457) }, { 0.48928d, new GammaParticle(293500.0, 0.00422) }, { 0.0027800000000000004d, new GammaParticle(384000.0, 0.00323) }, { 0.009729999999999999d, new GammaParticle(401600.0, 0.00309) }, { 0.02085d, new GammaParticle(517500.0, 0.0024) }, { 0.00417d, new GammaParticle(542700.0, 0.00228) }, { 0.0139d, new GammaParticle(564400.0, 0.0022) }, { 0.0139d, new GammaParticle(609000.0, 0.00204) }, { 0.00834d, new GammaParticle(677600.0, 0.00183) }, { 0.01668d, new GammaParticle(776900.0, 0.0016) }, { 0.00695d, new GammaParticle(784000.0, 0.00158) }, { 0.00834d, new GammaParticle(806500.0, 0.00154) }, { 0.012509999999999999d, new GammaParticle(836300.0, 0.00148) }, { 0.00417d, new GammaParticle(905000.0, 0.00137) }, { 0.012509999999999999d, new GammaParticle(1023100.0, 0.00121) }, { 0.03058d, new GammaParticle(1104500.0, 0.00112) }, { 0.009729999999999999d, new GammaParticle(1127700.0, 0.0011) }, { 0.012509999999999999d, new GammaParticle(1294500.0, 0.00096) }, { 0.01668d, new GammaParticle(1399200.0, 0.00089) }, { 0.088158743977993d, new GammaParticle(13292.0, 0.09328) }, { 0.06237255001882334d, new GammaParticle(76862.0, 0.01613) }, { 0.10386769362002221d, new GammaParticle(79290.0, 0.01564) }, { 0.03575877094290957d, new GammaParticle(89837.0, 0.0138) }, { 0.04687974870615444d, new GammaParticle(90941.0, 0.01363) }, { 0.011120977763244878d, new GammaParticle(92315.0, 0.01343) } } },

        };
    }
}
    