using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium180";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 179.95923d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium180() }, { 1.0d, new BetaParticle(1, 3929500.0) }, { 0.00208d, new GammaParticle(94500.0, 0.01312) }, { 0.35359999999999997d, new GammaParticle(132100.0, 0.00939) }, { 0.00832d, new GammaParticle(222000.0, 0.00558) }, { 0.002236d, new GammaParticle(257900.0, 0.00481) }, { 0.52d, new GammaParticle(276500.0, 0.00448) }, { 0.005719999999999999d, new GammaParticle(318100.0, 0.0039) }, { 0.005719999999999999d, new GammaParticle(326300.0, 0.0038) }, { 0.005719999999999999d, new GammaParticle(327000.0, 0.00379) }, { 0.01664d, new GammaParticle(352300.0, 0.00352) }, { 0.00208d, new GammaParticle(383100.0, 0.00324) }, { 0.062400000000000004d, new GammaParticle(386400.0, 0.00321) }, { 0.0052d, new GammaParticle(401900.0, 0.00308) }, { 0.00728d, new GammaParticle(407500.0, 0.00304) }, { 0.00468d, new GammaParticle(422300.0, 0.00294) }, { 0.005719999999999999d, new GammaParticle(461600.0, 0.00269) }, { 0.0338d, new GammaParticle(492200.0, 0.00252) }, { 0.01768d, new GammaParticle(505000.0, 0.00246) }, { 0.014039999999999999d, new GammaParticle(544300.0, 0.00228) }, { 0.00988d, new GammaParticle(583900.0, 0.00212) }, { 0.0104d, new GammaParticle(604100.0, 0.00205) }, { 0.00728d, new GammaParticle(610700.0, 0.00203) }, { 0.02028d, new GammaParticle(614100.0, 0.00202) }, { 0.08944d, new GammaParticle(644200.0, 0.00192) }, { 0.052000000000000005d, new GammaParticle(644800.0, 0.00192) }, { 0.03952d, new GammaParticle(684900.0, 0.00181) }, { 0.11492000000000001d, new GammaParticle(698900.0, 0.00177) }, { 0.023399999999999997d, new GammaParticle(738200.0, 0.00168) }, { 0.08839999999999999d, new GammaParticle(788300.0, 0.00157) }, { 0.01664d, new GammaParticle(809000.0, 0.00153) }, { 0.00416d, new GammaParticle(831500.0, 0.00149) }, { 0.09151999999999999d, new GammaParticle(870500.0, 0.00142) }, { 0.1092d, new GammaParticle(890700.0, 0.00139) }, { 0.015600000000000001d, new GammaParticle(920900.0, 0.00135) }, { 0.00234d, new GammaParticle(967100.0, 0.00128) }, { 0.0013d, new GammaParticle(969900.0, 0.00128) }, { 0.028079999999999997d, new GammaParticle(997000.0, 0.00124) }, { 0.039d, new GammaParticle(1064700.0, 0.00116) }, { 0.02392d, new GammaParticle(1106400.0, 0.00112) }, { 0.00312d, new GammaParticle(1195400.0, 0.00104) }, { 0.00936d, new GammaParticle(1243000.0, 0.001) }, { 1.1972d, new GammaParticle(511000.0, 0.00243) }, { 0.2478056070852947d, new GammaParticle(10393.0, 0.1193) }, { 0.15367442966690537d, new GammaParticle(61486.0, 0.02016) }, { 0.2648189379060923d, new GammaParticle(63000.0, 0.01968) }, { 0.0886028926658456d, new GammaParticle(71496.0, 0.01734) }, { 0.11341170261228237d, new GammaParticle(72338.0, 0.01714) }, { 0.024808809946436767d, new GammaParticle(73364.0, 0.0169) } } },

        };
    }
}
    