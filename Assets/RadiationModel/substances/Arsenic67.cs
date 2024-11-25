using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic67 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic67";
        public override double halfLife { get; } = 42.5d;
        public override double atomicWeight { get; } = 66.93925d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium67() }, { 1.0d, new BetaParticle(1, 5146000.0) }, { 0.00156d, new GammaParticle(18200.0, 0.06812) }, { 0.0452d, new GammaParticle(104400.0, 0.01188) }, { 0.09300000000000001d, new GammaParticle(120800.0, 0.01026) }, { 0.192d, new GammaParticle(122700.0, 0.0101) }, { 0.015d, new GammaParticle(225400.0, 0.0055) }, { 0.078d, new GammaParticle(243600.0, 0.00509) }, { 0.015d, new GammaParticle(248000.0, 0.005) }, { 0.02d, new GammaParticle(589000.0, 0.0021) }, { 0.025d, new GammaParticle(633000.0, 0.00196) }, { 0.022000000000000002d, new GammaParticle(685500.0, 0.00181) }, { 0.048d, new GammaParticle(693100.0, 0.00179) }, { 0.01d, new GammaParticle(776400.0, 0.0016) }, { 0.048d, new GammaParticle(789900.0, 0.00157) }, { 0.062d, new GammaParticle(808100.0, 0.00153) }, { 0.031d, new GammaParticle(897400.0, 0.00138) }, { 0.0029d, new GammaParticle(1049600.0, 0.00118) }, { 0.0058d, new GammaParticle(1151400.0, 0.00108) }, { 0.015d, new GammaParticle(1171300.0, 0.00106) }, { 0.013000000000000001d, new GammaParticle(1274300.0, 0.00097) }, { 0.013999999999999999d, new GammaParticle(1294000.0, 0.00096) }, { 0.0033d, new GammaParticle(1385200.0, 0.0009) }, { 0.0070999999999999995d, new GammaParticle(1576000.0, 0.00079) }, { 0.0038d, new GammaParticle(1657000.0, 0.00075) }, { 0.0038d, new GammaParticle(2128400.0, 0.00058) }, { 0.039d, new GammaParticle(2218200.0, 0.00056) }, { 0.0029d, new GammaParticle(2280000.0, 0.00054) }, { 1.983d, new GammaParticle(511000.0, 0.00243) }, { 0.009452007550678d, new GammaParticle(1221.0, 1.01543) }, { 0.0563399046489045d, new GammaParticle(9856.0, 0.1258) }, { 0.10941911953564673d, new GammaParticle(9887.0, 0.1254) }, { 0.024474595645253207d, new GammaParticle(11026.0, 0.11245) }, { 0.02501303674944878d, new GammaParticle(11038.0, 0.11232) }, { 0.0005384411041955705d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    