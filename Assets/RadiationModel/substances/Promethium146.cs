using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium146";
        public override double halfLife { get; } = 174509800.63949d;
        public override double atomicWeight { get; } = 145.9147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.657d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium146() }, { 0.0022d, new GammaParticle(146200.0, 0.00848) }, { 0.647d, new GammaParticle(453830.0, 0.00273) }, { 0.006d, new GammaParticle(589700.0, 0.0021) }, { 0.22899999999999998d, new GammaParticle(735900.0, 0.00168) }, { 0.0794164253736d, new GammaParticle(5870.0, 0.21122) }, { 0.14388569082851302d, new GammaParticle(36848.0, 0.03365) }, { 0.26203913827811515d, new GammaParticle(37362.0, 0.03318) }, { 0.08047451663752725d, new GammaParticle(42380.0, 0.02926) }, { 0.10115646741337175d, new GammaParticle(42810.0, 0.02896) }, { 0.0206819507758445d, new GammaParticle(43335.0, 0.02861) } } },
            { 0.34299999999999997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium146() }, { 1.0d, new BetaParticle(-1, 771000.0) }, { 0.022400000000000003d, new GammaParticle(633250.0, 0.00196) }, { 0.341d, new GammaParticle(747240.0, 0.00166) }, { 0.00023256624508d, new GammaParticle(6354.0, 0.19513) }, { 0.00038057406383379763d, new GammaParticle(39522.0, 0.03137) }, { 0.0006888218349932988d, new GammaParticle(40117.0, 0.03091) }, { 0.00021532430935842888d, new GammaParticle(45523.0, 0.02724) }, { 0.0002708779811729035d, new GammaParticle(45998.0, 0.02695) }, { 5.555367181447465e-05d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    