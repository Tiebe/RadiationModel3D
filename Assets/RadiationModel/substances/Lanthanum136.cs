using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum136 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum136";
        public override double halfLife { get; } = 592.2d;
        public override double atomicWeight { get; } = 135.90763d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium136() }, { 1.0d, new BetaParticle(1, 149450.0) }, { 4.6e-05d, new GammaParticle(541500.0, 0.00229) }, { 0.0001104d, new GammaParticle(732600.0, 0.00169) }, { 0.0028865d, new GammaParticle(760500.0, 0.00163) }, { 3.68e-05d, new GammaParticle(767000.0, 0.00162) }, { 0.023d, new GammaParticle(818510.0, 0.00151) }, { 4.6e-05d, new GammaParticle(894000.0, 0.00139) }, { 1.15e-05d, new GammaParticle(906800.0, 0.00137) }, { 2.07e-05d, new GammaParticle(935000.0, 0.00133) }, { 1.15e-06d, new GammaParticle(981300.0, 0.00126) }, { 9.2e-06d, new GammaParticle(1221400.0, 0.00102) }, { 0.000299d, new GammaParticle(1262100.0, 0.00098) }, { 0.0009912999999999999d, new GammaParticle(1310410.0, 0.00095) }, { 0.002645d, new GammaParticle(1322990.0, 0.00094) }, { 2.76e-05d, new GammaParticle(1466000.0, 0.00085) }, { 0.0004278d, new GammaParticle(1496910.0, 0.00083) }, { 2.3e-05d, new GammaParticle(1514500.0, 0.00082) }, { 0.0001104d, new GammaParticle(1551200.0, 0.0008) }, { 0.0001104d, new GammaParticle(1666900.0, 0.00074) }, { 2.3e-06d, new GammaParticle(1713200.0, 0.00072) }, { 6.67e-05d, new GammaParticle(1791400.0, 0.00069) }, { 3.45e-05d, new GammaParticle(1822000.0, 0.00068) }, { 1.6100000000000002e-05d, new GammaParticle(1955000.0, 0.00063) }, { 0.0001932d, new GammaParticle(2080600.0, 0.0006) }, { 0.0004692d, new GammaParticle(2129000.0, 0.00058) }, { 4.6e-06d, new GammaParticle(2286000.0, 0.00054) }, { 2.3e-05d, new GammaParticle(2332500.0, 0.00053) }, { 3.2200000000000003e-05d, new GammaParticle(2485400.0, 0.0005) }, { 0.7062999999999999d, new GammaParticle(511000.0, 0.00243) }, { 0.062d, new GammaParticle(4966.0, 0.24967) }, { 0.141d, new GammaParticle(31816.0, 0.03897) }, { 0.26d, new GammaParticle(32193.0, 0.03851) }, { 0.076d, new GammaParticle(36482.0, 0.03399) }, { 0.096d, new GammaParticle(36827.0, 0.03367) }, { 0.0192d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    