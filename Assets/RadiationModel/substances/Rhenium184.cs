using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium184";
        public override double halfLife { get; } = 3058560.0d;
        public override double atomicWeight { get; } = 183.95253d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum184() }, { 1.0d, new BetaParticle(1, -690500.0) }, { 0.172189d, new GammaParticle(111217.4, 0.01115) }, { 1.7681999999999998e-05d, new GammaParticle(124060.0, 0.00999) }, { 1.5997999999999998e-05d, new GammaParticle(127670.0, 0.00971) }, { 0.00018103000000000002d, new GammaParticle(226748.0, 0.00547) }, { 0.00014735d, new GammaParticle(230450.0, 0.00538) }, { 0.030312000000000002d, new GammaParticle(252845.0, 0.0049) }, { 5.894e-05d, new GammaParticle(256300.0, 0.00484) }, { 1.5156e-05d, new GammaParticle(265000.0, 0.00468) }, { 0.00021891999999999997d, new GammaParticle(295010.0, 0.0042) }, { 4.6309999999999995e-05d, new GammaParticle(380340.0, 0.00326) }, { 5.472999999999999e-05d, new GammaParticle(384250.0, 0.00323) }, { 6.735999999999999e-05d, new GammaParticle(385400.0, 0.00322) }, { 0.00018523999999999998d, new GammaParticle(482980.0, 0.00257) }, { 0.0032838d, new GammaParticle(539220.0, 0.0023) }, { 0.0194923d, new GammaParticle(641915.0, 0.00193) }, { 0.00061887d, new GammaParticle(757360.0, 0.00164) }, { 0.006736d, new GammaParticle(769778.0, 0.00161) }, { 0.376795d, new GammaParticle(792067.0, 0.00157) }, { 0.157033d, new GammaParticle(894760.0, 0.00139) }, { 0.381005d, new GammaParticle(903282.0, 0.00137) }, { 0.00091778d, new GammaParticle(1010240.0, 0.00123) }, { 1.1367e-05d, new GammaParticle(1018930.0, 0.00122) }, { 0.005220399999999999d, new GammaParticle(1022630.0, 0.00121) }, { 2.6102000000000002e-05d, new GammaParticle(1061040.0, 0.00117) }, { 0.00035364d, new GammaParticle(1121440.0, 0.00111) }, { 0.00119985d, new GammaParticle(1275110.0, 0.00097) }, { 0.000111986d, new GammaParticle(1313790.0, 0.00094) }, { 2.2734e-05d, new GammaParticle(1319940.0, 0.00094) }, { 0.00103145d, new GammaParticle(1386330.0, 0.00089) }, { 2.3996999999999997e-05d, new GammaParticle(1430960.0, 0.00087) }, { 0.32899999999999996d, new GammaParticle(9740.0, 0.12729) }, { 0.254d, new GammaParticle(57983.0, 0.02138) }, { 0.441d, new GammaParticle(59320.0, 0.0209) }, { 0.146d, new GammaParticle(67335.0, 0.01841) }, { 0.18600000000000003d, new GammaParticle(68117.0, 0.0182) }, { 0.04d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    