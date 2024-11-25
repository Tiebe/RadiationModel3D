using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium139";
        public override double halfLife { get; } = 15876.0d;
        public override double atomicWeight { get; } = 138.90893d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum139() }, { 1.0d, new BetaParticle(1, 1196700.0) }, { 0.00235554d, new GammaParticle(255110.0, 0.00486) }, { 0.00011825d, new GammaParticle(354000.0, 0.0035) }, { 7.095e-05d, new GammaParticle(587370.0, 0.00211) }, { 2.838e-05d, new GammaParticle(664600.0, 0.00187) }, { 2.838e-05d, new GammaParticle(696010.0, 0.00178) }, { 0.0001419d, new GammaParticle(754240.0, 0.00164) }, { 0.00013244d, new GammaParticle(824000.0, 0.0015) }, { 2.4596000000000003e-05d, new GammaParticle(1065320.0, 0.00116) }, { 3.1218e-05d, new GammaParticle(1088700.0, 0.00114) }, { 1.419e-05d, new GammaParticle(1091400.0, 0.00114) }, { 0.00069531d, new GammaParticle(1320240.0, 0.00094) }, { 4.73e-05d, new GammaParticle(1341500.0, 0.00092) }, { 0.00473d, new GammaParticle(1347330.0, 0.00092) }, { 0.00153725d, new GammaParticle(1375560.0, 0.0009) }, { 1.8920000000000002e-05d, new GammaParticle(1517200.0, 0.00082) }, { 0.00041624d, new GammaParticle(1563380.0, 0.00079) }, { 0.00034056d, new GammaParticle(1596580.0, 0.00078) }, { 0.00342925d, new GammaParticle(1630670.0, 0.00076) }, { 0.00038786d, new GammaParticle(1652580.0, 0.00075) }, { 1.419e-05d, new GammaParticle(1678500.0, 0.00074) }, { 1.7028e-05d, new GammaParticle(1710270.0, 0.00072) }, { 8.987e-05d, new GammaParticle(1729890.0, 0.00072) }, { 0.00030745d, new GammaParticle(1818300.0, 0.00068) }, { 0.00017028d, new GammaParticle(1907610.0, 0.00065) }, { 7.095e-06d, new GammaParticle(1965660.0, 0.00063) }, { 7.095e-06d, new GammaParticle(1985040.0, 0.00062) }, { 0.00011825d, new GammaParticle(2016250.0, 0.00061) }, { 4.7300000000000005e-06d, new GammaParticle(2090000.0, 0.00059) }, { 0.1656d, new GammaParticle(511000.0, 0.00243) }, { 0.099d, new GammaParticle(5410.0, 0.22918) }, { 0.20080247457956424d, new GammaParticle(34279.0, 0.03617) }, { 0.36777009996257193d, new GammaParticle(34720.0, 0.03571) }, { 0.11076736838966816d, new GammaParticle(39366.0, 0.0315) }, { 0.1389022799606439d, new GammaParticle(39753.0, 0.03119) }, { 0.028134911570975713d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    