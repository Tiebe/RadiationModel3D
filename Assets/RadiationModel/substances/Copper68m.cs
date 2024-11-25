using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper68m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper68m";
        public override double halfLife { get; } = 225.0d;
        public override double atomicWeight { get; } = 67.93039d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper68() }, { 0.82d, new GammaParticle(84120.0, 0.01474) }, { 0.166d, new GammaParticle(110740.0, 0.0112) }, { 0.748d, new GammaParticle(526440.0, 0.00236) }, { 0.0037d, new GammaParticle(610300.0, 0.00203) }, { 0.107d, new GammaParticle(637140.0, 0.00195) }, { 0.00851058228528897d, new GammaParticle(952.0, 1.30236) }, { 0.07841189797858586d, new GammaParticle(8028.0, 0.15444) }, { 0.15276037011218752d, new GammaParticle(8048.0, 0.15406) }, { 0.03215606249142658d, new GammaParticle(8940.0, 0.13868) }, { 0.03215606249142658d, new GammaParticle(8940.0, 0.13868) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc68() }, { 1.0d, new BetaParticle(-1, 2580750.0) }, { 0.054000000000000006d, new GammaParticle(151600.0, 0.00818) }, { 0.0058d, new GammaParticle(585600.0, 0.00212) }, { 0.0060999999999999995d, new GammaParticle(670700.0, 0.00185) }, { 0.009000000000000001d, new GammaParticle(1014500.0, 0.00122) }, { 0.09300000000000001d, new GammaParticle(1041000.0, 0.00119) }, { 0.14d, new GammaParticle(1077700.0, 0.00115) }, { 0.0029d, new GammaParticle(1149400.0, 0.00108) }, { 0.008d, new GammaParticle(1222200.0, 0.00101) }, { 0.0029d, new GammaParticle(1261800.0, 0.00098) }, { 0.006d, new GammaParticle(1292900.0, 0.00096) }, { 0.12d, new GammaParticle(1340500.0, 0.00092) }, { 0.0033d, new GammaParticle(1385800.0, 0.00089) }, { 0.008d, new GammaParticle(1432800.0, 0.00087) }, { 0.008d, new GammaParticle(1540700.0, 0.0008) }, { 0.0033d, new GammaParticle(1743700.0, 0.00071) }, { 0.00032d, new GammaParticle(2339500.0, 0.00053) }, { 1.62396821653776e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.00015204651590615374d, new GammaParticle(8616.0, 0.1439) }, { 0.0002956952856984709d, new GammaParticle(8639.0, 0.14352) }, { 6.344501328737532e-05d, new GammaParticle(9610.0, 0.12902) }, { 6.344501328737532e-05d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    