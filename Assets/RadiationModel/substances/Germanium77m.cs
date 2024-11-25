using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium77m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium77m";
        public override double halfLife { get; } = 53.7d;
        public override double atomicWeight { get; } = 76.92372d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic77() }, { 1.0d, new BetaParticle(-1, 1431570.0) }, { 0.0049d, new GammaParticle(194800.0, 0.00636) }, { 0.21d, new GammaParticle(215530.0, 0.00575) }, { 0.00021999999999999998d, new GammaParticle(264400.0, 0.00469) }, { 0.00095d, new GammaParticle(419400.0, 0.00296) }, { 0.0005d, new GammaParticle(503860.0, 0.00246) }, { 0.00045d, new GammaParticle(614430.0, 0.00202) }, { 0.00024d, new GammaParticle(990300.0, 0.00125) }, { 5.3e-05d, new GammaParticle(1061600.0, 0.00117) }, { 3.1e-05d, new GammaParticle(1100800.0, 0.00113) }, { 4e-05d, new GammaParticle(1172400.0, 0.00106) }, { 0.00015d, new GammaParticle(1340000.0, 0.00093) }, { 7.1e-05d, new GammaParticle(1389100.0, 0.00089) }, { 0.00106d, new GammaParticle(1409940.0, 0.00088) }, { 6.7e-05d, new GammaParticle(1412500.0, 0.00088) }, { 6.2e-05d, new GammaParticle(1461300.0, 0.00085) }, { 0.00046d, new GammaParticle(1481730.0, 0.00084) }, { 0.0021d, new GammaParticle(1604650.0, 0.00077) }, { 0.0016200000000000001d, new GammaParticle(1676460.0, 0.00074) }, { 4.9e-05d, new GammaParticle(2006200.0, 0.00062) }, { 5.323545556e-05d, new GammaParticle(1320.0, 0.93927) }, { 0.00043362053463685336d, new GammaParticle(10509.0, 0.11798) }, { 0.0008414914314707032d, new GammaParticle(10544.0, 0.11759) }, { 0.00019240945643904739d, new GammaParticle(11773.0, 0.10531) }, { 0.00019968253389244337d, new GammaParticle(11791.0, 0.10515) }, { 7.273077453395991e-06d, new GammaParticle(11861.0, 0.10453) } } },
            { 0.19d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium77() }, { 0.10300000000000001d, new GammaParticle(159700.0, 0.00776) }, { 0.001449883414d, new GammaParticle(1221.0, 1.01543) }, { 0.011775447994701642d, new GammaParticle(9856.0, 0.1258) }, { 0.02286938822043434d, new GammaParticle(9887.0, 0.1254) }, { 0.005115367695561663d, new GammaParticle(11026.0, 0.11245) }, { 0.00522790578486402d, new GammaParticle(11038.0, 0.11232) }, { 0.00011253808930235658d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    