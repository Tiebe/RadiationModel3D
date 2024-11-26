using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium256";
        public override double halfLife { get; } = 1524.0d;
        public override double atomicWeight { get; } = 256.0936d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fermium256() }, { 1.0d, new BetaParticle(-1, betaMinusSpectrum) }, { 0.06527999999999999d, new GammaParticle(96800.0, 0.01281) }, { 0.02048d, new GammaParticle(103600.0, 0.01197) }, { 0.131072d, new GammaParticle(105800.0, 0.01172) }, { 0.071424d, new GammaParticle(111600.0, 0.01111) }, { 0.018176d, new GammaParticle(126000.0, 0.00984) }, { 0.131072d, new GammaParticle(134700.0, 0.0092) }, { 0.002304d, new GammaParticle(141000.0, 0.00879) }, { 0.029695999999999997d, new GammaParticle(150200.0, 0.00825) }, { 0.002048d, new GammaParticle(156000.0, 0.00795) }, { 0.007936d, new GammaParticle(158900.0, 0.0078) }, { 0.0128d, new GammaParticle(165200.0, 0.00751) }, { 0.24832d, new GammaParticle(172600.0, 0.00718) }, { 0.028159999999999998d, new GammaParticle(178000.0, 0.00697) }, { 0.028159999999999998d, new GammaParticle(178000.0, 0.00697) }, { 0.007168d, new GammaParticle(181500.0, 0.00683) }, { 0.0064d, new GammaParticle(185700.0, 0.00668) }, { 0.014079999999999999d, new GammaParticle(190100.0, 0.00652) }, { 0.0030719999999999996d, new GammaParticle(192000.0, 0.00646) }, { 0.020224000000000002d, new GammaParticle(197400.0, 0.00628) }, { 0.035840000000000004d, new GammaParticle(199300.0, 0.00622) }, { 0.022272d, new GammaParticle(211200.0, 0.00587) }, { 0.022272d, new GammaParticle(211200.0, 0.00587) }, { 0.145664d, new GammaParticle(218100.0, 0.00568) }, { 0.01664d, new GammaParticle(229000.0, 0.00541) }, { 0.3072d, new GammaParticle(231100.0, 0.00536) }, { 0.014847999999999998d, new GammaParticle(232700.0, 0.00533) }, { 0.009216d, new GammaParticle(240300.0, 0.00516) }, { 0.020224000000000002d, new GammaParticle(242000.0, 0.00512) }, { 0.009728d, new GammaParticle(247400.0, 0.00501) }, { 0.001792d, new GammaParticle(252000.0, 0.00492) }, { 0.0064d, new GammaParticle(252700.0, 0.00491) }, { 0.014079999999999999d, new GammaParticle(255300.0, 0.00486) }, { 0.01664d, new GammaParticle(258200.0, 0.0048) }, { 0.009728d, new GammaParticle(264100.0, 0.00469) }, { 0.0192d, new GammaParticle(269500.0, 0.0046) }, { 0.02944d, new GammaParticle(275300.0, 0.0045) }, { 0.01536d, new GammaParticle(277300.0, 0.00447) }, { 0.013312d, new GammaParticle(297500.0, 0.00417) }, { 0.020992d, new GammaParticle(302000.0, 0.00411) }, { 0.026112000000000003d, new GammaParticle(316400.0, 0.00392) }, { 0.035072d, new GammaParticle(326700.0, 0.0038) }, { 0.009216d, new GammaParticle(333200.0, 0.00372) }, { 0.012544d, new GammaParticle(343000.0, 0.00361) }, { 0.036608d, new GammaParticle(374200.0, 0.00331) }, { 0.009728d, new GammaParticle(380000.0, 0.00326) }, { 0.018944000000000003d, new GammaParticle(397200.0, 0.00312) }, { 0.009728d, new GammaParticle(410000.0, 0.00302) }, { 0.039168d, new GammaParticle(417600.0, 0.00297) }, { 0.00384d, new GammaParticle(450800.0, 0.00275) }, { 0.023039999999999998d, new GammaParticle(468400.0, 0.00265) }, { 0.020992d, new GammaParticle(526100.0, 0.00236) }, { 0.0128d, new GammaParticle(566000.0, 0.00219) }, { 0.00512d, new GammaParticle(586600.0, 0.00211) }, { 0.019712d, new GammaParticle(602800.0, 0.00206) }, { 0.01024d, new GammaParticle(606600.0, 0.00204) }, { 0.028672d, new GammaParticle(623500.0, 0.00199) }, { 0.044288d, new GammaParticle(634000.0, 0.00196) }, { 0.056576d, new GammaParticle(677500.0, 0.00183) }, { 0.047104d, new GammaParticle(682300.0, 0.00182) }, { 0.02048d, new GammaParticle(693800.0, 0.00179) }, { 0.02944d, new GammaParticle(706800.0, 0.00175) }, { 0.058368d, new GammaParticle(762700.0, 0.00163) }, { 0.0576d, new GammaParticle(768100.0, 0.00161) }, { 0.13952d, new GammaParticle(833500.0, 0.00149) }, { 0.051712d, new GammaParticle(846700.0, 0.00146) }, { 0.503296d, new GammaParticle(861800.0, 0.00144) }, { 0.02048d, new GammaParticle(940100.0, 0.00132) }, { 0.065536d, new GammaParticle(1051500.0, 0.00118) }, { 0.23654399999999998d, new GammaParticle(1092900.0, 0.00113) }, { 0.9077881942096129d, new GammaParticle(20618.0, 0.06013) }, { 0.06289196709431791d, new GammaParticle(115320.0, 0.01075) }, { 0.09619450457986833d, new GammaParticle(121090.0, 0.01024) }, { 0.03754908632898072d, new GammaParticle(136318.0, 0.0091) }, { 0.05106675740741379d, new GammaParticle(138067.0, 0.00898) }, { 0.01351767107843306d, new GammaParticle(140406.0, 0.00883) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    