using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium220";
        public override double halfLife { get; } = 0.0264d;
        public override double atomicWeight { get; } = 220.01475d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium216() }, { 1.0d, new AlphaParticle(9370002.09) }, { 0.002d, new GammaParticle(34900.0, 0.03553) }, { 0.002d, new GammaParticle(37400.0, 0.03315) }, { 0.003d, new GammaParticle(42500.0, 0.02917) }, { 0.003d, new GammaParticle(53600.0, 0.02313) }, { 0.0066d, new GammaParticle(57900.0, 0.02141) }, { 0.018000000000000002d, new GammaParticle(64300.0, 0.01928) }, { 0.005d, new GammaParticle(78600.0, 0.01577) }, { 0.037000000000000005d, new GammaParticle(92800.0, 0.01336) }, { 0.025d, new GammaParticle(94800.0, 0.01308) }, { 0.005699999999999999d, new GammaParticle(112700.0, 0.011) }, { 0.013500000000000002d, new GammaParticle(118200.0, 0.01049) }, { 0.008d, new GammaParticle(121000.0, 0.01025) }, { 0.0055000000000000005d, new GammaParticle(123300.0, 0.01006) }, { 0.003d, new GammaParticle(127100.0, 0.00975) }, { 0.004d, new GammaParticle(130400.0, 0.00951) }, { 0.08199999999999999d, new GammaParticle(133300.0, 0.0093) }, { 0.015d, new GammaParticle(137300.0, 0.00903) }, { 0.0132d, new GammaParticle(141600.0, 0.00876) }, { 0.0095d, new GammaParticle(149000.0, 0.00832) }, { 0.006999999999999999d, new GammaParticle(151500.0, 0.00818) }, { 0.0182d, new GammaParticle(153100.0, 0.0081) }, { 0.033d, new GammaParticle(160000.0, 0.00775) }, { 0.0043d, new GammaParticle(169200.0, 0.00733) }, { 0.005d, new GammaParticle(172200.0, 0.0072) }, { 0.0038d, new GammaParticle(179300.0, 0.00691) }, { 0.0054d, new GammaParticle(182800.0, 0.00678) }, { 0.0144d, new GammaParticle(187800.0, 0.0066) }, { 0.003d, new GammaParticle(197300.0, 0.00628) }, { 0.003d, new GammaParticle(203600.0, 0.00609) }, { 0.012d, new GammaParticle(206700.0, 0.006) }, { 0.0051d, new GammaParticle(214800.0, 0.00577) }, { 0.0062d, new GammaParticle(221300.0, 0.0056) }, { 0.0105d, new GammaParticle(238800.0, 0.00519) }, { 0.018000000000000002d, new GammaParticle(243700.0, 0.00509) }, { 0.004699999999999999d, new GammaParticle(247800.0, 0.005) }, { 0.0054d, new GammaParticle(254400.0, 0.00487) }, { 0.005d, new GammaParticle(260800.0, 0.00475) }, { 0.0062d, new GammaParticle(263600.0, 0.0047) }, { 0.009000000000000001d, new GammaParticle(265400.0, 0.00467) }, { 0.018000000000000002d, new GammaParticle(267800.0, 0.00463) }, { 0.02d, new GammaParticle(296400.0, 0.00418) }, { 0.013000000000000001d, new GammaParticle(301400.0, 0.00411) }, { 0.01d, new GammaParticle(305600.0, 0.00406) }, { 0.013999999999999999d, new GammaParticle(312900.0, 0.00396) }, { 0.004d, new GammaParticle(327000.0, 0.00379) }, { 0.035d, new GammaParticle(342700.0, 0.00362) }, { 0.002d, new GammaParticle(378000.0, 0.00328) }, { 0.0066d, new GammaParticle(390200.0, 0.00318) }, { 0.002d, new GammaParticle(448400.0, 0.00277) }, { 0.5444935051600001d, new GammaParticle(14500.0, 0.08551) }, { 0.0964019959307409d, new GammaParticle(83227.0, 0.0149) }, { 0.15824359148184652d, new GammaParticle(86102.0, 0.0144) }, { 0.05519885467327234d, new GammaParticle(97469.0, 0.01272) }, { 0.07308328358741259d, new GammaParticle(98682.0, 0.01256) }, { 0.017884428914140237d, new GammaParticle(100209.0, 0.01237) } } },
            { 5e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium220() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    