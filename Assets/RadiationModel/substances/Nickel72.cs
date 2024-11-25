using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel72 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel72";
        public override double halfLife { get; } = 1.57d;
        public override double atomicWeight { get; } = 71.94179d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper72() }, { 1.0d, new BetaParticle(-1, 2778450.0) }, { 0.006750000000000001d, new GammaParticle(74800.0, 0.01658) }, { 0.2025d, new GammaParticle(94000.0, 0.01319) }, { 0.0375d, new GammaParticle(137400.0, 0.00902) }, { 0.01575d, new GammaParticle(202600.0, 0.00612) }, { 0.0165d, new GammaParticle(297000.0, 0.00417) }, { 0.02475d, new GammaParticle(314300.0, 0.00394) }, { 0.75d, new GammaParticle(376400.0, 0.00329) }, { 0.0375d, new GammaParticle(451700.0, 0.00274) }, { 0.0105d, new GammaParticle(476000.0, 0.0026) }, { 0.09d, new GammaParticle(987300.0, 0.00126) }, { 0.0165d, new GammaParticle(1141300.0, 0.00109) }, { 0.00525d, new GammaParticle(1332500.0, 0.00093) }, { 0.013500000000000002d, new GammaParticle(1387500.0, 0.00089) }, { 0.0045000000000000005d, new GammaParticle(1421800.0, 0.00087) }, { 0.00375d, new GammaParticle(1443400.0, 0.00086) }, { 0.00975d, new GammaParticle(1517400.0, 0.00082) }, { 0.01725d, new GammaParticle(1518000.0, 0.00082) }, { 0.00975d, new GammaParticle(1590000.0, 0.00078) }, { 0.045d, new GammaParticle(1684000.0, 0.00074) }, { 0.0345d, new GammaParticle(1726200.0, 0.00072) }, { 0.02175d, new GammaParticle(1745200.0, 0.00071) }, { 0.015d, new GammaParticle(1762200.0, 0.0007) }, { 0.01425d, new GammaParticle(1820200.0, 0.00068) }, { 0.006750000000000001d, new GammaParticle(1895000.0, 0.00065) }, { 0.045d, new GammaParticle(2060300.0, 0.0006) }, { 0.0022500000000000003d, new GammaParticle(2120000.0, 0.00058) }, { 0.006750000000000001d, new GammaParticle(2221000.0, 0.00056) }, { 1.0009417875e-05d, new GammaParticle(952.0, 1.30236) }, { 9.581495612922107e-05d, new GammaParticle(8028.0, 0.15444) }, { 0.0001866646330201073d, new GammaParticle(8048.0, 0.15406) }, { 3.9292910850671576e-05d, new GammaParticle(8940.0, 0.13868) }, { 3.9292910850671576e-05d, new GammaParticle(8940.0, 0.13868) } } },

        };
    }
}
    