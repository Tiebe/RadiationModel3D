using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium125";
        public override double halfLife { get; } = 2802.0d;
        public override double atomicWeight { get; } = 124.90973d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine125() }, { 1.0d, new BetaParticle(1, 2373000.0) }, { 0.08618d, new GammaParticle(112000.0, 0.01107) }, { 0.02046d, new GammaParticle(335000.0, 0.0037) }, { 0.0527d, new GammaParticle(412000.0, 0.00301) }, { 0.01581d, new GammaParticle(428000.0, 0.0029) }, { 0.24552d, new GammaParticle(526000.0, 0.00236) }, { 0.031d, new GammaParticle(540000.0, 0.0023) }, { 0.031d, new GammaParticle(600000.0, 0.00207) }, { 0.00434d, new GammaParticle(654000.0, 0.0019) }, { 0.035339999999999996d, new GammaParticle(712000.0, 0.00174) }, { 0.00217d, new GammaParticle(780000.0, 0.00159) }, { 0.000775d, new GammaParticle(808000.0, 0.00153) }, { 0.0030380000000000003d, new GammaParticle(865000.0, 0.00143) }, { 0.008369999999999999d, new GammaParticle(922000.0, 0.00134) }, { 0.00527d, new GammaParticle(995000.0, 0.00125) }, { 0.0018290000000000001d, new GammaParticle(1060000.0, 0.00117) }, { 0.00434d, new GammaParticle(1158000.0, 0.00107) }, { 0.0018599999999999999d, new GammaParticle(1200000.0, 0.00103) }, { 0.0034100000000000003d, new GammaParticle(1212000.0, 0.00102) }, { 0.00155d, new GammaParticle(1228000.0, 0.00101) }, { 0.00217d, new GammaParticle(1311000.0, 0.00095) }, { 0.0009299999999999999d, new GammaParticle(1326000.0, 0.00094) }, { 0.002635d, new GammaParticle(1468000.0, 0.00084) }, { 0.0027900000000000004d, new GammaParticle(1579000.0, 0.00079) }, { 0.0027900000000000004d, new GammaParticle(1698000.0, 0.00073) }, { 0.00217d, new GammaParticle(1783000.0, 0.0007) }, { 0.00124d, new GammaParticle(1825000.0, 0.00068) }, { 0.0018599999999999999d, new GammaParticle(1855000.0, 0.00067) }, { 0.00062d, new GammaParticle(2044000.0, 0.00061) }, { 0.008060000000000001d, new GammaParticle(2116000.0, 0.00059) }, { 0.0018599999999999999d, new GammaParticle(2154000.0, 0.00058) }, { 0.00124d, new GammaParticle(2201000.0, 0.00056) }, { 0.00124d, new GammaParticle(2269000.0, 0.00055) }, { 0.00046499999999999997d, new GammaParticle(2414000.0, 0.00051) }, { 0.00062d, new GammaParticle(2431000.0, 0.00051) }, { 0.00124d, new GammaParticle(2523000.0, 0.00049) }, { 0.000248d, new GammaParticle(2545000.0, 0.00049) }, { 0.00046499999999999997d, new GammaParticle(2623000.0, 0.00047) }, { 0.00046499999999999997d, new GammaParticle(2726000.0, 0.00045) }, { 0.794676d, new GammaParticle(511000.0, 0.00243) }, { 0.056453415744362d, new GammaParticle(4540.0, 0.27309) }, { 0.14163101606536593d, new GammaParticle(29458.0, 0.04209) }, { 0.26237683598622813d, new GammaParticle(29778.0, 0.04164) }, { 0.07606199609417957d, new GammaParticle(33726.0, 0.03676) }, { 0.09401262717240595d, new GammaParticle(34030.0, 0.03643) }, { 0.01795063107822638d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    