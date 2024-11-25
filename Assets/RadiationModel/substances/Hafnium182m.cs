using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium182m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium182m";
        public override double halfLife { get; } = 3690.0d;
        public override double atomicWeight { get; } = 181.95182d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.54d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum182() }, { 1.0d, new BetaParticle(-1, 776849.99999) }, { 3.3e-06d, new GammaParticle(16273.0, 0.07619) }, { 0.05d, new GammaParticle(59100.0, 0.02098) }, { 0.013999999999999999d, new GammaParticle(75600.0, 0.0164) }, { 0.044000000000000004d, new GammaParticle(97800.0, 0.01268) }, { 0.071d, new GammaParticle(114300.0, 0.01085) }, { 0.034d, new GammaParticle(132800.0, 0.00934) }, { 0.049d, new GammaParticle(143200.0, 0.00866) }, { 0.054000000000000006d, new GammaParticle(146800.0, 0.00845) }, { 0.044000000000000004d, new GammaParticle(171500.0, 0.00723) }, { 0.032d, new GammaParticle(173400.0, 0.00715) }, { 0.025d, new GammaParticle(178700.0, 0.00694) }, { 0.025d, new GammaParticle(185000.0, 0.0067) }, { 0.012d, new GammaParticle(195800.0, 0.00633) }, { 0.011000000000000001d, new GammaParticle(220800.0, 0.00562) }, { 0.0064d, new GammaParticle(318300.0, 0.0039) }, { 0.065d, new GammaParticle(339600.0, 0.00365) }, { 0.06d, new GammaParticle(603200.0, 0.00206) }, { 0.013000000000000001d, new GammaParticle(613300.0, 0.00202) }, { 0.012d, new GammaParticle(627400.0, 0.00198) }, { 0.10800000000000001d, new GammaParticle(799600.0, 0.00155) }, { 0.03d, new GammaParticle(823200.0, 0.00151) }, { 0.22d, new GammaParticle(942800.0, 0.00132) }, { 0.0028000000000000004d, new GammaParticle(952900.0, 0.0013) }, { 0.2732110415323456d, new GammaParticle(9424.0, 0.13156) }, { 0.19740080413190234d, new GammaParticle(56280.0, 0.02203) }, { 0.34414366131782137d, new GammaParticle(57535.0, 0.02155) }, { 0.11385226163391832d, new GammaParticle(65315.0, 0.01898) }, { 0.14459237227507626d, new GammaParticle(66067.0, 0.01877) }, { 0.030740110641157944d, new GammaParticle(66981.0, 0.01851) } } },
            { 0.46d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium182() }, { 0.132d, new GammaParticle(50800.0, 0.02441) }, { 0.092d, new GammaParticle(97800.0, 0.01268) }, { 0.38d, new GammaParticle(224400.0, 0.00553) }, { 0.46d, new GammaParticle(344100.0, 0.0036) }, { 0.2d, new GammaParticle(455800.0, 0.00272) }, { 0.23d, new GammaParticle(506600.0, 0.00245) }, { 0.10961971904000001d, new GammaParticle(9114.0, 0.13604) }, { 0.04845015328619935d, new GammaParticle(54608.0, 0.0227) }, { 0.08479200785124143d, new GammaParticle(55786.0, 0.02222) }, { 0.02797349239349585d, new GammaParticle(63333.0, 0.01958) }, { 0.03544241486255924d, new GammaParticle(64057.0, 0.01936) }, { 0.007468922469063392d, new GammaParticle(64935.0, 0.01909) } } },

        };
    }
}
    