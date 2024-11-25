using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium119m";
        public override double halfLife { get; } = 406080.0d;
        public override double atomicWeight { get; } = 118.90669d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin119() }, { 1.0d, new BetaParticle(1, 1571500.0) }, { 0.0044948d, new GammaParticle(116620.0, 0.01063) }, { 0.6609999999999999d, new GammaParticle(153590.0, 0.00807) }, { 0.012955600000000001d, new GammaParticle(164340.0, 0.00754) }, { 0.00026440000000000003d, new GammaParticle(184110.0, 0.00673) }, { 0.0003305d, new GammaParticle(190540.0, 0.00651) }, { 0.00013220000000000001d, new GammaParticle(201170.0, 0.00616) }, { 0.0005949d, new GammaParticle(241780.0, 0.00513) }, { 0.279603d, new GammaParticle(270530.0, 0.00458) }, { 0.0003305d, new GammaParticle(369700.0, 0.00335) }, { 0.003305d, new GammaParticle(395420.0, 0.00314) }, { 0.004627d, new GammaParticle(700330.0, 0.00177) }, { 0.00046269999999999997d, new GammaParticle(760300.0, 0.00163) }, { 0.000661d, new GammaParticle(777910.0, 0.00159) }, { 0.0010576000000000001d, new GammaParticle(818800.0, 0.00151) }, { 0.0015864d, new GammaParticle(859680.0, 0.00144) }, { 0.0038338d, new GammaParticle(871460.0, 0.00142) }, { 0.0623984d, new GammaParticle(912600.0, 0.00136) }, { 0.0008593d, new GammaParticle(917600.0, 0.00135) }, { 0.050830900000000005d, new GammaParticle(942210.0, 0.00132) }, { 0.0008593d, new GammaParticle(952820.0, 0.0013) }, { 0.0023135d, new GammaParticle(970910.0, 0.00128) }, { 0.0009915d, new GammaParticle(972800.0, 0.00127) }, { 0.027101d, new GammaParticle(976370.0, 0.00127) }, { 0.0300755d, new GammaParticle(979290.0, 0.00127) }, { 0.016525d, new GammaParticle(1013200.0, 0.00122) }, { 0.008593d, new GammaParticle(1013200.0, 0.00122) }, { 0.0318602d, new GammaParticle(1048440.0, 0.00118) }, { 0.0009915d, new GammaParticle(1066300.0, 0.00116) }, { 0.0159301d, new GammaParticle(1081350.0, 0.00115) }, { 0.0223418d, new GammaParticle(1095750.0, 0.00113) }, { 0.00011237000000000001d, new GammaParticle(1111200.0, 0.00112) }, { 0.07647770000000001d, new GammaParticle(1136750.0, 0.00109) }, { 0.6609999999999999d, new GammaParticle(1212730.0, 0.00102) }, { 0.00173182d, new GammaParticle(1249650.0, 0.00099) }, { 0.00015203d, new GammaParticle(1255640.0, 0.00099) }, { 0.0012228500000000002d, new GammaParticle(1312010.0, 0.00094) }, { 0.010642100000000002d, new GammaParticle(1366390.0, 0.00091) }, { 0.0003305d, new GammaParticle(1391900.0, 0.00089) }, { 0.001322d, new GammaParticle(1407430.0, 0.00088) }, { 0.0001983d, new GammaParticle(1700800.0, 0.00073) }, { 0.0013881d, new GammaParticle(1859000.0, 0.00067) }, { 0.00026440000000000003d, new GammaParticle(1955450.0, 0.00063) }, { 0.0031728d, new GammaParticle(2013200.0, 0.00062) }, { 0.0467988d, new GammaParticle(2089570.0, 0.00059) }, { 0.00026440000000000003d, new GammaParticle(2126300.0, 0.00058) }, { 0.00026440000000000003d, new GammaParticle(2225600.0, 0.00056) }, { 6.610000000000001e-05d, new GammaParticle(2242000.0, 0.00055) }, { 0.000661d, new GammaParticle(2360400.0, 0.00053) }, { 0.00741d, new GammaParticle(511000.0, 0.00243) }, { 0.07504121794039097d, new GammaParticle(3941.0, 0.3146) }, { 0.21945188756705356d, new GammaParticle(26111.0, 0.04748) }, { 0.4097309327241478d, new GammaParticle(26359.0, 0.04704) }, { 0.11655781161318361d, new GammaParticle(29821.0, 0.04158) }, { 0.1406852786171126d, new GammaParticle(30069.0, 0.04123) }, { 0.024127467003929003d, new GammaParticle(30387.0, 0.0408) } } },
            { 0.0040999999999999995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony119() }, { 1.0d, new BetaParticle(1, 1277000.0) } } },
            { 8e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium119() } } },

        };
    }
}
    