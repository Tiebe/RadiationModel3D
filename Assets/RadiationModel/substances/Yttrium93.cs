using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium93";
        public override double halfLife { get; } = 36648.0d;
        public override double atomicWeight { get; } = 92.90958d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium93() }, { 1.0d, new BetaParticle(-1, 1447500.0) }, { 0.074176d, new GammaParticle(266900.0, 0.00465) }, { 0.000722d, new GammaParticle(273000.0, 0.00454) }, { 0.0007599999999999999d, new GammaParticle(287000.0, 0.00432) }, { 0.0004484d, new GammaParticle(341500.0, 0.00363) }, { 7.6e-05d, new GammaParticle(387500.0, 0.0032) }, { 0.0066652d, new GammaParticle(680200.0, 0.00182) }, { 0.0001748d, new GammaParticle(714400.0, 0.00174) }, { 0.021204d, new GammaParticle(947100.0, 0.00131) }, { 0.0001216d, new GammaParticle(962300.0, 0.00129) }, { 6.84e-05d, new GammaParticle(971000.0, 0.00128) }, { 0.0001064d, new GammaParticle(987700.0, 0.00126) }, { 0.000304d, new GammaParticle(1158500.0, 0.00107) }, { 0.0001064d, new GammaParticle(1168610.0, 0.00106) }, { 0.0004864d, new GammaParticle(1183500.0, 0.00105) }, { 0.0001976d, new GammaParticle(1184700.0, 0.00105) }, { 0.0010868d, new GammaParticle(1203300.0, 0.00103) }, { 0.0002964d, new GammaParticle(1237400.0, 0.001) }, { 0.0024776d, new GammaParticle(1425400.0, 0.00087) }, { 0.0033136d, new GammaParticle(1450500.0, 0.00085) }, { 0.0006612d, new GammaParticle(1470100.0, 0.00084) }, { 0.0005244d, new GammaParticle(1642700.0, 0.00075) }, { 0.0002356d, new GammaParticle(1651700.0, 0.00075) }, { 0.0002356d, new GammaParticle(1827800.0, 0.00068) }, { 0.015656d, new GammaParticle(1917800.0, 0.00065) }, { 0.0015884d, new GammaParticle(2184600.0, 0.00057) }, { 0.0017100000000000001d, new GammaParticle(2190800.0, 0.00057) }, { 6.84e-05d, new GammaParticle(2457300.0, 0.0005) }, { 0.000114d, new GammaParticle(2473800.0, 0.0005) }, { 0.000114d, new GammaParticle(2605000.0, 0.00048) }, { 6.164860298171681e-05d, new GammaParticle(2161.0, 0.57374) }, { 0.00034696834950149504d, new GammaParticle(15691.0, 0.07902) }, { 0.0006640542574191293d, new GammaParticle(15775.0, 0.0786) }, { 0.0001692095427638532d, new GammaParticle(17736.0, 0.06991) }, { 0.00019391413600737575d, new GammaParticle(17824.0, 0.06956) }, { 2.4704593243522567e-05d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    