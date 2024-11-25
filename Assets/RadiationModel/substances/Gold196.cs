using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold196 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196";
        public override double halfLife { get; } = 532820.16d;
        public override double atomicWeight { get; } = 195.96657d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium196() }, { 1.0d, new BetaParticle(1, -849349.99999) }, { 0.0005d, new GammaParticle(326200.0, 0.0038) }, { 0.22899999999999998d, new GammaParticle(333030.0, 0.00372) }, { 0.87d, new GammaParticle(355730.0, 0.00349) }, { 0.000101d, new GammaParticle(393400.0, 0.00315) }, { 6.7e-05d, new GammaParticle(432000.0, 0.00287) }, { 0.0038900000000000002d, new GammaParticle(521400.0, 0.00238) }, { 6.9e-05d, new GammaParticle(570800.0, 0.00217) }, { 3.7000000000000005e-05d, new GammaParticle(659500.0, 0.00188) }, { 2.7000000000000002e-05d, new GammaParticle(673500.0, 0.00184) }, { 6.1000000000000005e-05d, new GammaParticle(688760.0, 0.0018) }, { 0.000443d, new GammaParticle(759100.0, 0.00163) }, { 2.7000000000000002e-05d, new GammaParticle(1005700.0, 0.00123) }, { 0.00149d, new GammaParticle(1091400.0, 0.00114) }, { 4.2999999999999995e-06d, new GammaParticle(1361000.0, 0.00091) }, { 7.8e-06d, new GammaParticle(1446300.0, 0.00086) }, { 0.266d, new GammaParticle(11070.0, 0.112) }, { 0.21899999999999997d, new GammaParticle(65122.0, 0.01904) }, { 0.374d, new GammaParticle(66832.0, 0.01855) }, { 0.126d, new GammaParticle(75821.0, 0.01635) }, { 0.162d, new GammaParticle(76725.0, 0.01616) }, { 0.036000000000000004d, new GammaParticle(77832.0, 0.01593) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury196() }, { 1.0d, new BetaParticle(-1, 343600.00001) }, { 0.066d, new GammaParticle(426100.0, 0.00291) }, { 0.0007483565429999999d, new GammaParticle(11777.0, 0.10528) }, { 0.0005113952491048017d, new GammaParticle(68894.0, 0.018) }, { 0.0008669185439986466d, new GammaParticle(70820.0, 0.01751) }, { 0.00029421083286662933d, new GammaParticle(80316.0, 0.01544) }, { 0.0003804146068965517d, new GammaParticle(81285.0, 0.01525) }, { 8.62037740299224e-05d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    