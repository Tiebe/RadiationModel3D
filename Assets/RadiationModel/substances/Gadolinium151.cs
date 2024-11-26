using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium151";
        public override double halfLife { get; } = 10704960.0d;
        public override double atomicWeight { get; } = 150.92035d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium151()), new(0.02852d, new GammaParticle(21517.0, 0.05762)), new(8.68e-06d, new GammaParticle(63920.0, 0.0194)), new(9.3e-06d, new GammaParticle(64200.0, 0.01931)), new(1.86e-05d, new GammaParticle(93210.0, 0.0133)), new(0.0008680000000000001d, new GammaParticle(106570.0, 0.01163)), new(2.8519999999999998e-05d, new GammaParticle(109740.0, 0.0113)), new(4.96e-05d, new GammaParticle(110330.0, 0.01124)), new(6.819999999999999e-05d, new GammaParticle(110760.0, 0.01119)), new(0.062d, new GammaParticle(153600.0, 0.00807)), new(7.44e-06d, new GammaParticle(157080.0, 0.00789)), new(0.029636d, new GammaParticle(174700.0, 0.0071)), new(8.68e-06d, new GammaParticle(195180.0, 0.00635)), new(0.0002852d, new GammaParticle(196200.0, 0.00632)), new(0.0002852d, new GammaParticle(196490.0, 0.00631)), new(2.294e-05d, new GammaParticle(221800.0, 0.00559)), new(0.0008680000000000001d, new GammaParticle(238970.0, 0.00519)), new(0.055986d, new GammaParticle(243290.0, 0.0051)), new(0.0004278d, new GammaParticle(260460.0, 0.00476)), new(2.48e-05d, new GammaParticle(269500.0, 0.0046)), new(2.17e-05d, new GammaParticle(284720.0, 0.00435)), new(0.0008928d, new GammaParticle(286090.0, 0.00433)), new(2.48e-05d, new GammaParticle(298970.0, 0.00415)), new(0.010354d, new GammaParticle(307500.0, 0.00403)), new(0.0008246000000000001d, new GammaParticle(328310.0, 0.00378)), new(8.68e-05d, new GammaParticle(332110.0, 0.00373)), new(1.6119999999999998e-05d, new GammaParticle(338500.0, 0.00366)), new(2.48e-05d, new GammaParticle(345000.0, 0.00359)), new(3.286e-05d, new GammaParticle(349850.0, 0.00354)), new(0.0012772d, new GammaParticle(353660.0, 0.00351)), new(6.0139999999999995e-06d, new GammaParticle(394260.0, 0.00314)), new(4.34e-06d, new GammaParticle(415840.0, 0.00298)), new(0.26d, new GammaParticle(6603.0, 0.18777)), new(0.235d, new GammaParticle(40901.0, 0.03031)), new(0.42d, new GammaParticle(41541.0, 0.02985)), new(0.133d, new GammaParticle(47146.0, 0.0263)), new(0.168d, new GammaParticle(47645.0, 0.02602)), new(0.034d, new GammaParticle(48248.0, 0.0257)) } },
            { 7.999999999999999e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium147()), new(1.0d, new AlphaParticle(3674102.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    