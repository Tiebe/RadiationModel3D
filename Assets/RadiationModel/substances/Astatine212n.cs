using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine212n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212n";
        public override double halfLife { get; } = 0.00015d;
        public override double atomicWeight { get; } = 211.99586d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine212() }, { 0.0129d, new GammaParticle(37700.0, 0.03289) }, { 0.01634d, new GammaParticle(63900.0, 0.0194) }, { 0.0043d, new GammaParticle(106300.0, 0.01166) }, { 0.07826d, new GammaParticle(107200.0, 0.01157) }, { 0.0215d, new GammaParticle(159300.0, 0.00778) }, { 0.0043d, new GammaParticle(170100.0, 0.00729) }, { 0.00602d, new GammaParticle(176500.0, 0.00702) }, { 0.25542000000000004d, new GammaParticle(183700.0, 0.00675) }, { 0.0688d, new GammaParticle(223700.0, 0.00554) }, { 0.25026d, new GammaParticle(224200.0, 0.00553) }, { 0.0051600000000000005d, new GammaParticle(228000.0, 0.00544) }, { 0.00774d, new GammaParticle(237000.0, 0.00523) }, { 0.86d, new GammaParticle(278100.0, 0.00446) }, { 0.0129d, new GammaParticle(295400.0, 0.0042) }, { 0.00602d, new GammaParticle(318300.0, 0.0039) }, { 0.03268d, new GammaParticle(350300.0, 0.00354) }, { 0.01204d, new GammaParticle(360600.0, 0.00344) }, { 0.7009000000000001d, new GammaParticle(377000.0, 0.00329) }, { 0.05074d, new GammaParticle(448100.0, 0.00277) }, { 0.27262000000000003d, new GammaParticle(478500.0, 0.00259) }, { 0.02752d, new GammaParticle(482400.0, 0.00257) }, { 0.03354d, new GammaParticle(486000.0, 0.00255) }, { 0.0043d, new GammaParticle(525500.0, 0.00236) }, { 0.73616d, new GammaParticle(533800.0, 0.00232) }, { 0.01548d, new GammaParticle(547300.0, 0.00227) }, { 0.0989d, new GammaParticle(557500.0, 0.00222) }, { 0.020640000000000002d, new GammaParticle(560000.0, 0.00221) }, { 0.08944d, new GammaParticle(566800.0, 0.00219) }, { 0.00774d, new GammaParticle(588800.0, 0.00211) }, { 0.6794d, new GammaParticle(607800.0, 0.00204) }, { 0.1032d, new GammaParticle(645500.0, 0.00192) }, { 0.5108400000000001d, new GammaParticle(662400.0, 0.00187) }, { 0.0043d, new GammaParticle(708700.0, 0.00175) }, { 0.0172d, new GammaParticle(757800.0, 0.00164) }, { 0.00774d, new GammaParticle(784300.0, 0.00158) }, { 0.0129d, new GammaParticle(848000.0, 0.00146) }, { 0.0025800000000000003d, new GammaParticle(885000.0, 0.0014) }, { 0.00344d, new GammaParticle(1059300.0, 0.00117) }, { 0.06278d, new GammaParticle(1076000.0, 0.00115) }, { 0.06622d, new GammaParticle(1085400.0, 0.00114) }, { 0.086d, new GammaParticle(1094000.0, 0.00113) }, { 0.010320000000000001d, new GammaParticle(1242500.0, 0.001) }, { 0.010320000000000001d, new GammaParticle(1265400.0, 0.00098) }, { 0.01376d, new GammaParticle(1406000.0, 0.00088) }, { 0.7077800000000001d, new GammaParticle(1643000.0, 0.00075) }, { 0.10578d, new GammaParticle(2176500.0, 0.00057) }, { 2.62d, new GammaParticle(13686.0, 0.09059) }, { 0.342d, new GammaParticle(78947.0, 0.0157) }, { 0.5670000000000001d, new GammaParticle(81517.0, 0.01521) }, { 0.196d, new GammaParticle(92333.0, 0.01343) }, { 0.258d, new GammaParticle(93473.0, 0.01326) }, { 0.061799999999999994d, new GammaParticle(94897.0, 0.01307) } } },

        };
    }
}
    