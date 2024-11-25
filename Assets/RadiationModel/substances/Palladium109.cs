using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109";
        public override double halfLife { get; } = 48924.0d;
        public override double atomicWeight { get; } = 108.90595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver109() }, { 1.0d, new BetaParticle(-1, 556450.0) }, { 1.222e-05d, new GammaParticle(44770.0, 0.02769) }, { 0.03666d, new GammaParticle(88033.6, 0.01408) }, { 6.682e-06d, new GammaParticle(103827.0, 0.01194) }, { 6.499999999999999e-07d, new GammaParticle(114260.0, 0.01085) }, { 1.5391999999999998e-05d, new GammaParticle(134107.0, 0.00925) }, { 9.958e-06d, new GammaParticle(145039.0, 0.00855) }, { 1.066e-06d, new GammaParticle(162370.0, 0.00764) }, { 5.72e-08d, new GammaParticle(282441.0, 0.00439) }, { 1.807e-06d, new GammaParticle(286644.0, 0.00433) }, { 4.238e-05d, new GammaParticle(309182.0, 0.00401) }, { 0.000338d, new GammaParticle(311390.0, 0.00398) }, { 4.68e-07d, new GammaParticle(327171.0, 0.00379) }, { 9.126e-06d, new GammaParticle(390515.0, 0.00317) }, { 7.331999999999999e-07d, new GammaParticle(395590.0, 0.00313) }, { 6.499999999999999e-07d, new GammaParticle(402050.0, 0.00308) }, { 7.176e-05d, new GammaParticle(413010.0, 0.003) }, { 0.00011414d, new GammaParticle(415222.0, 0.00299) }, { 9.958e-06d, new GammaParticle(423942.0, 0.00292) }, { 9.724e-06d, new GammaParticle(447426.0, 0.00277) }, { 4.446e-06d, new GammaParticle(454269.0, 0.00273) }, { 8.294000000000001e-07d, new GammaParticle(497010.0, 0.00249) }, { 4.68e-07d, new GammaParticle(500600.0, 0.00248) }, { 7.332e-06d, new GammaParticle(551258.0, 0.00225) }, { 2.704e-05d, new GammaParticle(558040.0, 0.00222) }, { 1.144e-06d, new GammaParticle(564300.0, 0.0022) }, { 1.56e-07d, new GammaParticle(601100.0, 0.00206) }, { 8.736e-05d, new GammaParticle(602568.0, 0.00206) }, { 3.9e-08d, new GammaParticle(609370.0, 0.00203) }, { 0.0001105d, new GammaParticle(636342.0, 0.00195) }, { 0.00026d, new GammaParticle(647272.0, 0.00192) }, { 3.4580000000000004e-05d, new GammaParticle(701876.0, 0.00177) }, { 1.6458e-05d, new GammaParticle(706964.0, 0.00175) }, { 6.24e-07d, new GammaParticle(724372.0, 0.00171) }, { 1.7602e-05d, new GammaParticle(736652.0, 0.00168) }, { 1.1153999999999999e-05d, new GammaParticle(778140.0, 0.00159) }, { 0.00012116d, new GammaParticle(781394.0, 0.00159) }, { 2.08e-06d, new GammaParticle(787600.0, 0.00157) }, { 1.9734e-06d, new GammaParticle(822862.0, 0.00151) }, { 1.7731999999999998e-06d, new GammaParticle(862637.0, 0.00144) }, { 1.56e-07d, new GammaParticle(869415.0, 0.00143) }, { 3.77e-07d, new GammaParticle(966290.0, 0.00128) }, { 2.392e-07d, new GammaParticle(1011160.0, 0.00123) }, { 0.0493d, new GammaParticle(3218.0, 0.38528) }, { 0.099d, new GammaParticle(21990.0, 0.05638) }, { 0.187d, new GammaParticle(22163.0, 0.05594) }, { 0.0519d, new GammaParticle(25030.0, 0.04953) }, { 0.060899999999999996d, new GammaParticle(25211.0, 0.04918) }, { 0.009000000000000001d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    