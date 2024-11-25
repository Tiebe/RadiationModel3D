using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177";
        public override double halfLife { get; } = 202896.0d;
        public override double atomicWeight { get; } = 176.94448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium177() }, { 1.0d, new BetaParticle(1, 334450.0) }, { 0.00023d, new GammaParticle(71641.8, 0.01731) }, { 0.00014000000000000001d, new GammaParticle(96300.0, 0.01287) }, { 0.00010200000000000001d, new GammaParticle(105358.9, 0.01177) }, { 0.114d, new GammaParticle(112949.8, 0.01098) }, { 1.6e-05d, new GammaParticle(129900.0, 0.00954) }, { 0.000114d, new GammaParticle(136724.5, 0.00907) }, { 8.599999999999999e-06d, new GammaParticle(142400.0, 0.00871) }, { 2.8999999999999997e-05d, new GammaParticle(177000.7, 0.007) }, { 4.6e-05d, new GammaParticle(197100.0, 0.00629) }, { 0.015d, new GammaParticle(208366.2, 0.00595) }, { 7.000000000000001e-05d, new GammaParticle(210200.0, 0.0059) }, { 0.00049d, new GammaParticle(249674.2, 0.00497) }, { 1.4e-05d, new GammaParticle(256900.0, 0.00483) }, { 2.1000000000000002e-06d, new GammaParticle(268500.0, 0.00462) }, { 8.8e-06d, new GammaParticle(283200.0, 0.00438) }, { 2.1e-05d, new GammaParticle(297700.0, 0.00416) }, { 7.699999999999999e-06d, new GammaParticle(311900.0, 0.00398) }, { 1.05e-05d, new GammaParticle(313725.0, 0.00395) }, { 3.7000000000000005e-05d, new GammaParticle(319300.0, 0.00388) }, { 0.00031d, new GammaParticle(321315.9, 0.00386) }, { 3e-05d, new GammaParticle(354900.0, 0.00349) }, { 2.5e-06d, new GammaParticle(365100.0, 0.0034) }, { 8.3e-05d, new GammaParticle(395200.0, 0.00314) }, { 8.9e-06d, new GammaParticle(398300.0, 0.00311) }, { 0.00049d, new GammaParticle(420800.0, 0.00295) }, { 0.0016d, new GammaParticle(424600.0, 0.00292) }, { 5.500000000000001e-06d, new GammaParticle(439900.0, 0.00282) }, { 3.6e-05d, new GammaParticle(453200.0, 0.00274) }, { 0.00049d, new GammaParticle(491500.0, 0.00252) }, { 6.7e-05d, new GammaParticle(494700.0, 0.00251) }, { 0.00111d, new GammaParticle(508100.0, 0.00244) }, { 0.00027d, new GammaParticle(526100.0, 0.00236) }, { 9.499999999999999e-05d, new GammaParticle(549600.0, 0.00226) }, { 0.00015d, new GammaParticle(597700.0, 0.00207) }, { 0.00034d, new GammaParticle(604400.0, 0.00205) }, { 0.00046d, new GammaParticle(632900.0, 0.00196) }, { 1.1900000000000001e-05d, new GammaParticle(681500.0, 0.00182) }, { 0.00062d, new GammaParticle(734400.0, 0.00169) }, { 0.00025d, new GammaParticle(736400.0, 0.00168) }, { 0.0033d, new GammaParticle(745900.0, 0.00166) }, { 1.05e-05d, new GammaParticle(760000.0, 0.00163) }, { 4.3e-05d, new GammaParticle(805700.0, 0.00154) }, { 0.00043d, new GammaParticle(847400.0, 0.00146) }, { 1.4e-05d, new GammaParticle(873000.0, 0.00142) }, { 0.0008799999999999999d, new GammaParticle(944800.0, 0.00131) }, { 1.6e-05d, new GammaParticle(1002800.0, 0.00124) }, { 0.0046d, new GammaParticle(1057800.0, 0.00117) }, { 0.26d, new GammaParticle(9114.0, 0.13604) }, { 0.25d, new GammaParticle(54608.0, 0.0227) }, { 0.43d, new GammaParticle(55786.0, 0.02222) }, { 0.14300000000000002d, new GammaParticle(63333.0, 0.01958) }, { 0.18100000000000002d, new GammaParticle(64057.0, 0.01936) }, { 0.038d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    