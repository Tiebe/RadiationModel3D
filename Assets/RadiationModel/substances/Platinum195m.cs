using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum195m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum195m";
        public override double halfLife { get; } = 346464.0d;
        public override double atomicWeight { get; } = 194.96507d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum195() }, { 3.64e-12d, new GammaParticle(19800.0, 0.06262) }, { 1.3806000000000001e-05d, new GammaParticle(28100.0, 0.04412) }, { 0.023751d, new GammaParticle(30890.0, 0.04014) }, { 0.11699999999999999d, new GammaParticle(98900.0, 0.01254) }, { 0.0008774999999999999d, new GammaParticle(129500.0, 0.00957) }, { 0.029016d, new GammaParticle(129790.0, 0.00955) }, { 0.00030771d, new GammaParticle(140600.0, 0.00882) }, { 0.00039897d, new GammaParticle(211350.0, 0.00587) }, { 0.00055809d, new GammaParticle(239500.0, 0.00518) }, { 0.6939862161622511d, new GammaParticle(11070.0, 0.112) }, { 0.22236435665296672d, new GammaParticle(65122.0, 0.01904) }, { 0.3801100113725927d, new GammaParticle(66832.0, 0.01855) }, { 0.12789696926203556d, new GammaParticle(75821.0, 0.01635) }, { 0.16447550247097772d, new GammaParticle(76725.0, 0.01616) }, { 0.03657853320894217d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    