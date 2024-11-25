using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc61 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc61";
        public override double halfLife { get; } = 89.1d;
        public override double atomicWeight { get; } = 60.93951d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel61() }, { 1.0d, new BetaParticle(1, 3936500.0) }, { 0.0016852d, new GammaParticle(149000.0, 0.00832) }, { 0.0053620000000000004d, new GammaParticle(265900.0, 0.00466) }, { 0.0009192d, new GammaParticle(421000.0, 0.00294) }, { 0.0014554d, new GammaParticle(426000.0, 0.00291) }, { 0.165456d, new GammaParticle(475000.0, 0.00261) }, { 0.0006128d, new GammaParticle(594200.0, 0.00209) }, { 0.0008426d, new GammaParticle(604500.0, 0.00205) }, { 0.000766d, new GammaParticle(638200.0, 0.00194) }, { 0.018384d, new GammaParticle(690300.0, 0.0018) }, { 0.004213d, new GammaParticle(697600.0, 0.00178) }, { 0.003064d, new GammaParticle(751600.0, 0.00165) }, { 0.0009192d, new GammaParticle(919600.0, 0.00135) }, { 0.0008426d, new GammaParticle(934400.0, 0.00133) }, { 0.025278000000000002d, new GammaParticle(970000.0, 0.00128) }, { 0.0017618d, new GammaParticle(1131900.0, 0.0011) }, { 0.001532d, new GammaParticle(1147300.0, 0.00108) }, { 0.016928600000000002d, new GammaParticle(1185300.0, 0.00105) }, { 0.009192d, new GammaParticle(1311000.0, 0.00095) }, { 0.0119496d, new GammaParticle(1394600.0, 0.00089) }, { 0.003064d, new GammaParticle(1457800.0, 0.00085) }, { 0.0077366d, new GammaParticle(1482100.0, 0.00084) }, { 0.0013788000000000001d, new GammaParticle(1502400.0, 0.00083) }, { 0.0008349399999999999d, new GammaParticle(1538900.0, 0.00081) }, { 0.0010724d, new GammaParticle(1565600.0, 0.00079) }, { 0.0029108d, new GammaParticle(1613300.0, 0.00077) }, { 0.0766d, new GammaParticle(1660400.0, 0.00075) }, { 0.0013788000000000001d, new GammaParticle(1732600.0, 0.00072) }, { 0.0047109000000000005d, new GammaParticle(1883100.0, 0.00066) }, { 0.00089622d, new GammaParticle(1904100.0, 0.00065) }, { 0.006511d, new GammaParticle(1932400.0, 0.00064) }, { 0.0115666d, new GammaParticle(1997400.0, 0.00062) }, { 0.0061663d, new GammaParticle(2088900.0, 0.00059) }, { 0.0082728d, new GammaParticle(2209000.0, 0.00056) }, { 0.0032172d, new GammaParticle(2358600.0, 0.00053) }, { 0.0010724d, new GammaParticle(2381400.0, 0.00052) }, { 0.0064344d, new GammaParticle(2457600.0, 0.0005) }, { 0.000766d, new GammaParticle(2472100.0, 0.0005) }, { 0.00074302d, new GammaParticle(2543900.0, 0.00049) }, { 0.0066642d, new GammaParticle(2683300.0, 0.00046) }, { 0.0078898d, new GammaParticle(2792300.0, 0.00044) }, { 0.00243588d, new GammaParticle(2842800.0, 0.00044) }, { 0.004213d, new GammaParticle(2857000.0, 0.00043) }, { 0.0009192d, new GammaParticle(2931800.0, 0.00042) }, { 0.0018384d, new GammaParticle(3019300.0, 0.00041) }, { 0.001149d, new GammaParticle(3092300.0, 0.0004) }, { 0.0013788000000000001d, new GammaParticle(3521100.0, 0.00035) }, { 1.97072d, new GammaParticle(511000.0, 0.00243) }, { 0.00019800000000000002d, new GammaParticle(952.0, 1.30236) }, { 0.00188d, new GammaParticle(8028.0, 0.15444) }, { 0.00367d, new GammaParticle(8048.0, 0.15406) }, { 0.000772d, new GammaParticle(8940.0, 0.13868) }, { 0.000772d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    