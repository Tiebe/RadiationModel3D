using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon44 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon44";
        public override double halfLife { get; } = 712.2d;
        public override double atomicWeight { get; } = 43.96492d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium44() }, { 1.0d, new BetaParticle(-1, 1554100.0) }, { 0.00132d, new GammaParticle(137300.0, 0.00903) }, { 0.66d, new GammaParticle(182600.0, 0.00679) }, { 0.005148000000000001d, new GammaParticle(382900.0, 0.00324) }, { 0.04092d, new GammaParticle(408100.0, 0.00304) }, { 0.0264d, new GammaParticle(426700.0, 0.00291) }, { 0.00046199999999999995d, new GammaParticle(519400.0, 0.00239) }, { 0.0012540000000000001d, new GammaParticle(531200.0, 0.00233) }, { 0.00231d, new GammaParticle(693800.0, 0.00179) }, { 0.019799999999999998d, new GammaParticle(809100.0, 0.00153) }, { 0.016302d, new GammaParticle(866100.0, 0.00143) }, { 0.00033d, new GammaParticle(884900.0, 0.0014) }, { 0.006666d, new GammaParticle(894200.0, 0.00139) }, { 0.0015179999999999998d, new GammaParticle(911100.0, 0.00136) }, { 0.002178d, new GammaParticle(975000.0, 0.00127) }, { 0.039599999999999996d, new GammaParticle(1051300.0, 0.00118) }, { 0.009701999999999999d, new GammaParticle(1076600.0, 0.00115) }, { 0.02178d, new GammaParticle(1114700.0, 0.00111) }, { 0.015378000000000001d, new GammaParticle(1276600.0, 0.00097) }, { 0.02178d, new GammaParticle(1460000.0, 0.00085) }, { 0.005148000000000001d, new GammaParticle(1585700.0, 0.00078) }, { 0.006732d, new GammaParticle(1639700.0, 0.00076) }, { 0.56496d, new GammaParticle(1703400.0, 0.00073) }, { 0.001122d, new GammaParticle(1765400.0, 0.0007) }, { 0.31482d, new GammaParticle(1886100.0, 0.00066) }, { 0.007788000000000001d, new GammaParticle(2143500.0, 0.00058) }, { 0.001716d, new GammaParticle(2279900.0, 0.00054) }, { 0.008118d, new GammaParticle(2325800.0, 0.00053) }, { 1.87026576e-08d, new GammaParticle(311.0, 3.98663) }, { 2.5408354075146877e-07d, new GammaParticle(3311.0, 0.37446) }, { 5.026380628120056e-07d, new GammaParticle(3314.0, 0.37412) }, { 9.269839643652561e-08d, new GammaParticle(3591.0, 0.34526) }, { 9.269839643652561e-08d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    