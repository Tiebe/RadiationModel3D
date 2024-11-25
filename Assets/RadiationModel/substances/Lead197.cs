using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead197 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead197";
        public override double halfLife { get; } = 486.0d;
        public override double atomicWeight { get; } = 196.97344d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury197() }, { 1.0d, new BetaParticle(1, 2897500.0) }, { 0.1278d, new GammaParticle(375480.0, 0.0033) }, { 0.504d, new GammaParticle(385850.0, 0.00321) }, { 0.0207d, new GammaParticle(394740.0, 0.00314) }, { 0.01413d, new GammaParticle(520700.0, 0.00238) }, { 0.00243d, new GammaParticle(538800.0, 0.0023) }, { 0.1332d, new GammaParticle(761140.0, 0.00163) }, { 0.0252d, new GammaParticle(769840.0, 0.00161) }, { 0.010709999999999999d, new GammaParticle(815280.0, 0.00152) }, { 0.026099999999999998d, new GammaParticle(844180.0, 0.00147) }, { 0.061200000000000004d, new GammaParticle(871610.0, 0.00142) }, { 0.009000000000000001d, new GammaParticle(885430.0, 0.0014) }, { 0.0504d, new GammaParticle(896090.0, 0.00138) }, { 0.0315d, new GammaParticle(901680.0, 0.00138) }, { 0.0216d, new GammaParticle(913450.0, 0.00136) }, { 0.016200000000000003d, new GammaParticle(1003830.0, 0.00124) }, { 0.0063d, new GammaParticle(1063770.0, 0.00117) }, { 0.02088d, new GammaParticle(1088160.0, 0.00114) }, { 0.0333d, new GammaParticle(1092820.0, 0.00113) }, { 0.0189d, new GammaParticle(1140060.0, 0.00109) }, { 0.007019999999999999d, new GammaParticle(1147570.0, 0.00108) }, { 0.0378d, new GammaParticle(1156090.0, 0.00107) }, { 0.020339999999999997d, new GammaParticle(1208990.0, 0.00103) }, { 0.016739999999999998d, new GammaParticle(1219210.0, 0.00102) }, { 0.0828d, new GammaParticle(1261230.0, 0.00098) }, { 0.01476d, new GammaParticle(1277270.0, 0.00097) }, { 0.00396d, new GammaParticle(1281500.0, 0.00097) }, { 0.048600000000000004d, new GammaParticle(1288860.0, 0.00096) }, { 0.00738d, new GammaParticle(1382900.0, 0.0009) }, { 0.0189d, new GammaParticle(1584490.0, 0.00078) }, { 0.023399999999999997d, new GammaParticle(1647140.0, 0.00075) }, { 0.00612d, new GammaParticle(1663030.0, 0.00075) }, { 0.0297d, new GammaParticle(1674620.0, 0.00074) }, { 0.00486d, new GammaParticle(1727050.0, 0.00072) }, { 0.061200000000000004d, new GammaParticle(1854040.0, 0.00067) }, { 0.01206d, new GammaParticle(1975750.0, 0.00063) }, { 0.016739999999999998d, new GammaParticle(2043770.0, 0.00061) }, { 0.01089d, new GammaParticle(2112730.0, 0.00059) }, { 0.0064800000000000005d, new GammaParticle(2143670.0, 0.00058) }, { 0.0441d, new GammaParticle(2345450.0, 0.00053) }, { 0.00468d, new GammaParticle(2429020.0, 0.00051) }, { 0.07945d, new GammaParticle(511000.0, 0.00243) }, { 0.30962211964445197d, new GammaParticle(12148.0, 0.10206) }, { 0.23696034903737917d, new GammaParticle(70832.0, 0.0175) }, { 0.4000005891920648d, new GammaParticle(72874.0, 0.01701) }, { 0.13603560515771473d, new GammaParticle(82629.0, 0.015) }, { 0.176438179889556d, new GammaParticle(83631.0, 0.01483) }, { 0.04040257473184128d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    