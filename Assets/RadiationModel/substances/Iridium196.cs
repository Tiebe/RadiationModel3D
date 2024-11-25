using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium196";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 195.96839d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum196() }, { 1.0d, new BetaParticle(-1, 1602250.0) }, { 0.03852d, new GammaParticle(332900.0, 0.00372) }, { 0.18d, new GammaParticle(355700.0, 0.00349) }, { 0.03888d, new GammaParticle(446800.0, 0.00277) }, { 0.10926d, new GammaParticle(779600.0, 0.00159) }, { 0.0036d, new GammaParticle(1006000.0, 0.00123) }, { 0.01044d, new GammaParticle(1047000.0, 0.00118) }, { 0.0018d, new GammaParticle(1135000.0, 0.00109) }, { 0.0034200000000000003d, new GammaParticle(1228600.0, 0.00101) }, { 0.0045000000000000005d, new GammaParticle(1402000.0, 0.00088) }, { 0.009000000000000001d, new GammaParticle(1468400.0, 0.00084) }, { 0.0072d, new GammaParticle(1564200.0, 0.00079) }, { 0.0027d, new GammaParticle(1824000.0, 0.00068) }, { 0.005065802539678799d, new GammaParticle(11070.0, 0.112) }, { 0.0037938996768501843d, new GammaParticle(65122.0, 0.01904) }, { 0.006485298592906297d, new GammaParticle(66832.0, 0.01855) }, { 0.0021821315144972936d, new GammaParticle(75821.0, 0.01635) }, { 0.0028062211276435197d, new GammaParticle(76725.0, 0.01616) }, { 0.0006240896131462259d, new GammaParticle(77832.0, 0.01593) } } },

        };
    }
}
    