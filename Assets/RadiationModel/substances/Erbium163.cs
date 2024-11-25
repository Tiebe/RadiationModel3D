using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium163";
        public override double halfLife { get; } = 4500.0d;
        public override double atomicWeight { get; } = 162.93004d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium163() }, { 1.0d, new BetaParticle(1, 606950.0) }, { 4.6e-06d, new GammaParticle(80500.0, 0.0154) }, { 1.6904999999999998e-05d, new GammaParticle(100000.0, 0.0124) }, { 2.07e-06d, new GammaParticle(123600.0, 0.01003) }, { 4.6e-06d, new GammaParticle(164600.0, 0.00753) }, { 5.060000000000001e-06d, new GammaParticle(192600.0, 0.00644) }, { 3.795e-06d, new GammaParticle(253900.0, 0.00488) }, { 0.000115d, new GammaParticle(297800.0, 0.00416) }, { 2.07e-06d, new GammaParticle(331000.0, 0.00375) }, { 3.335e-05d, new GammaParticle(339800.0, 0.00365) }, { 8.74e-06d, new GammaParticle(417100.0, 0.00297) }, { 1.4375e-05d, new GammaParticle(431200.0, 0.00288) }, { 0.0002852d, new GammaParticle(436100.0, 0.00284) }, { 0.000276d, new GammaParticle(439900.0, 0.00282) }, { 9.085e-06d, new GammaParticle(444800.0, 0.00279) }, { 6.9e-06d, new GammaParticle(452300.0, 0.00274) }, { 2.76e-06d, new GammaParticle(484000.0, 0.00256) }, { 3.22e-06d, new GammaParticle(552000.0, 0.00225) }, { 5.865e-06d, new GammaParticle(558500.0, 0.00222) }, { 8.625e-06d, new GammaParticle(568400.0, 0.00218) }, { 1.334e-05d, new GammaParticle(578100.0, 0.00214) }, { 3.335e-05d, new GammaParticle(614300.0, 0.00202) }, { 1.2305e-05d, new GammaParticle(711300.0, 0.00174) }, { 6.9e-05d, new GammaParticle(875800.0, 0.00142) }, { 8.625e-06d, new GammaParticle(1013600.0, 0.00122) }, { 0.0004899d, new GammaParticle(1113500.0, 0.00111) }, { 6e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.1707639713360834d, new GammaParticle(7656.0, 0.16194) }, { 0.22205294856299396d, new GammaParticle(46700.0, 0.02655) }, { 0.39546384427959747d, new GammaParticle(47547.0, 0.02608) }, { 0.1277671649952886d, new GammaParticle(53982.0, 0.02297) }, { 0.16098662789406362d, new GammaParticle(54577.0, 0.02272) }, { 0.03321946289877503d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    