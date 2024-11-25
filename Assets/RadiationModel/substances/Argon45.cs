using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon45 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon45";
        public override double halfLife { get; } = 21.48d;
        public override double atomicWeight { get; } = 44.96804d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium45() }, { 1.0d, new BetaParticle(-1, 3422400.0) }, { 0.24989999999999998d, new GammaParticle(61340.0, 0.02021) }, { 0.023799999999999998d, new GammaParticle(474430.0, 0.00261) }, { 0.02754d, new GammaParticle(549080.0, 0.00226) }, { 0.02244d, new GammaParticle(557760.0, 0.00222) }, { 0.0032640000000000004d, new GammaParticle(597800.0, 0.00207) }, { 0.0032640000000000004d, new GammaParticle(597800.0, 0.00207) }, { 0.003094d, new GammaParticle(609000.0, 0.00204) }, { 0.02856d, new GammaParticle(619250.0, 0.002) }, { 0.01224d, new GammaParticle(685300.0, 0.00181) }, { 0.0029920000000000003d, new GammaParticle(845400.0, 0.00147) }, { 0.009656d, new GammaParticle(949800.0, 0.00131) }, { 0.34d, new GammaParticle(1020040.0, 0.00122) }, { 0.0085d, new GammaParticle(1042800.0, 0.00119) }, { 0.003774d, new GammaParticle(1053700.0, 0.00118) }, { 0.0255d, new GammaParticle(1081210.0, 0.00115) }, { 0.11593999999999999d, new GammaParticle(1106820.0, 0.00112) }, { 0.013395999999999998d, new GammaParticle(1123100.0, 0.0011) }, { 0.0064600000000000005d, new GammaParticle(1138200.0, 0.00109) }, { 0.003638d, new GammaParticle(1142500.0, 0.00109) }, { 0.003468d, new GammaParticle(1168500.0, 0.00106) }, { 0.008126d, new GammaParticle(1172700.0, 0.00106) }, { 0.004998d, new GammaParticle(1209500.0, 0.00103) }, { 0.004998d, new GammaParticle(1209500.0, 0.00103) }, { 0.003808d, new GammaParticle(1323200.0, 0.00094) }, { 0.006324d, new GammaParticle(1424400.0, 0.00087) }, { 0.00918d, new GammaParticle(1434800.0, 0.00086) }, { 0.014212d, new GammaParticle(1473600.0, 0.00084) }, { 0.0032979999999999997d, new GammaParticle(1485900.0, 0.00083) }, { 0.008704d, new GammaParticle(1548500.0, 0.0008) }, { 0.09214d, new GammaParticle(1638810.0, 0.00076) }, { 0.003536d, new GammaParticle(1670700.0, 0.00074) }, { 0.011661999999999999d, new GammaParticle(1722500.0, 0.00072) }, { 0.13226000000000002d, new GammaParticle(1808380.0, 0.00069) }, { 0.00748d, new GammaParticle(1840100.0, 0.00067) }, { 0.008159999999999999d, new GammaParticle(2283200.0, 0.00054) }, { 0.07888d, new GammaParticle(2357430.0, 0.00053) }, { 0.005678d, new GammaParticle(2489600.0, 0.0005) }, { 0.008159999999999999d, new GammaParticle(2517900.0, 0.00049) }, { 0.006324d, new GammaParticle(2549600.0, 0.00049) }, { 0.06188d, new GammaParticle(2687500.0, 0.00046) }, { 0.00561d, new GammaParticle(2749800.0, 0.00045) }, { 0.011696d, new GammaParticle(2796600.0, 0.00044) }, { 0.00272d, new GammaParticle(2885000.0, 0.00043) }, { 0.0051d, new GammaParticle(3338100.0, 0.00037) }, { 0.33286d, new GammaParticle(3703200.0, 0.00033) }, { 0.002788d, new GammaParticle(3995300.0, 0.00031) }, { 0.002686d, new GammaParticle(4043800.0, 0.00031) }, { 0.00442d, new GammaParticle(4356000.0, 0.00028) }, { 0.005304d, new GammaParticle(4568900.0, 0.00027) }, { 4.7199775657199996e-05d, new GammaParticle(311.0, 3.98663) }, { 0.0006414338986270831d, new GammaParticle(3311.0, 0.37446) }, { 0.001268909789568908d, new GammaParticle(3314.0, 0.37412) }, { 0.0002340171018040089d, new GammaParticle(3591.0, 0.34526) }, { 0.0002340171018040089d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    