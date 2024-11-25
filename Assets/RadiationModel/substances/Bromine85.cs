using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine85 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine85";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 84.91565d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton85() }, { 1.0d, new BetaParticle(-1, 1452650.0) }, { 0.00037653d, new GammaParticle(96870.0, 0.0128) }, { 0.0003912d, new GammaParticle(147630.0, 0.0084) }, { 0.00057702d, new GammaParticle(175910.0, 0.00705) }, { 0.00023635d, new GammaParticle(201870.0, 0.00614) }, { 8.476e-05d, new GammaParticle(235580.0, 0.00526) }, { 0.00020538000000000002d, new GammaParticle(249940.0, 0.00496) }, { 0.00010595d, new GammaParticle(263840.0, 0.0047) }, { 0.00072046d, new GammaParticle(272050.0, 0.00456) }, { 0.0009128d, new GammaParticle(421700.0, 0.00294) }, { 0.00014670000000000002d, new GammaParticle(433730.0, 0.00286) }, { 0.00020538000000000002d, new GammaParticle(455620.0, 0.00272) }, { 0.00020864d, new GammaParticle(541670.0, 0.00229) }, { 0.00015648d, new GammaParticle(546600.0, 0.00227) }, { 0.0001956d, new GammaParticle(600910.0, 0.00206) }, { 0.00040750000000000004d, new GammaParticle(689390.0, 0.0018) }, { 0.00011736d, new GammaParticle(766400.0, 0.00162) }, { 0.00012062d, new GammaParticle(771700.0, 0.00161) }, { 0.0010432d, new GammaParticle(794780.0, 0.00156) }, { 0.0004727d, new GammaParticle(798350.0, 0.00155) }, { 0.0255747d, new GammaParticle(802410.0, 0.00155) }, { 0.00014507000000000002d, new GammaParticle(810000.0, 0.00153) }, { 0.00012225d, new GammaParticle(824090.0, 0.0015) }, { 0.0005053d, new GammaParticle(831480.0, 0.00149) }, { 0.0022819999999999997d, new GammaParticle(861760.0, 0.00144) }, { 0.0017767d, new GammaParticle(865220.0, 0.00143) }, { 0.0013366d, new GammaParticle(913310.0, 0.00136) }, { 0.0065037d, new GammaParticle(919060.0, 0.00135) }, { 0.0163d, new GammaParticle(924630.0, 0.00134) }, { 0.00018256000000000001d, new GammaParticle(946200.0, 0.00131) }, { 0.0002282d, new GammaParticle(1029700.0, 0.0012) }, { 0.0005379d, new GammaParticle(1031870.0, 0.0012) }, { 0.0010269d, new GammaParticle(1037830.0, 0.00119) }, { 0.00021353d, new GammaParticle(1047420.0, 0.00118) }, { 0.00029829d, new GammaParticle(1072200.0, 0.00116) }, { 0.00031296d, new GammaParticle(1131620.0, 0.0011) }, { 0.0009617d, new GammaParticle(1140780.0, 0.00109) }, { 0.00047107000000000003d, new GammaParticle(1260450.0, 0.00098) }, { 0.0006683d, new GammaParticle(1416480.0, 0.00088) }, { 0.0038142d, new GammaParticle(1727020.0, 0.00072) }, { 0.00016299999999999998d, new GammaParticle(1808230.0, 0.00069) }, { 0.0014996d, new GammaParticle(1832500.0, 0.00068) }, { 0.00017930000000000002d, new GammaParticle(2438600.0, 0.00051) }, { 0.00016789d, new GammaParticle(2463400.0, 0.0005) } } },

        };
    }
}
    