using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium65";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 64.93937d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc65()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.2673d, new GammaParticle(62000.0, 0.02)), new(0.10329d, new GammaParticle(190800.0, 0.0065)), new(0.019799999999999998d, new GammaParticle(459100.0, 0.0027)), new(0.0264d, new GammaParticle(587700.0, 0.00211)), new(0.01518d, new GammaParticle(618700.0, 0.002)), new(0.33d, new GammaParticle(649700.0, 0.00191)), new(0.01287d, new GammaParticle(753000.0, 0.00165)), new(0.2145d, new GammaParticle(809100.0, 0.00153)), new(0.00363d, new GammaParticle(826800.0, 0.0015)), new(0.0033d, new GammaParticle(884900.0, 0.0014)), new(0.00231d, new GammaParticle(970700.0, 0.00128)), new(0.00924d, new GammaParticle(1070200.0, 0.00116)), new(0.00825d, new GammaParticle(1075900.0, 0.00115)), new(0.00132d, new GammaParticle(1150700.0, 0.00108)), new(0.00462d, new GammaParticle(1183600.0, 0.00105)), new(0.01221d, new GammaParticle(1205700.0, 0.00103)), new(0.022109999999999998d, new GammaParticle(1229800.0, 0.00101)), new(0.01254d, new GammaParticle(1237100.0, 0.001)), new(0.0033d, new GammaParticle(1511900.0, 0.00082)), new(0.0069299999999999995d, new GammaParticle(1600800.0, 0.00077)), new(0.00726d, new GammaParticle(1616600.0, 0.00077)), new(0.022109999999999998d, new GammaParticle(1688500.0, 0.00073)), new(0.00396d, new GammaParticle(1816300.0, 0.00068)), new(0.00957d, new GammaParticle(1879200.0, 0.00066)), new(0.00396d, new GammaParticle(1902000.0, 0.00065)), new(0.01485d, new GammaParticle(2099600.0, 0.00059)), new(0.0033d, new GammaParticle(2121600.0, 0.00058)), new(0.0033d, new GammaParticle(2121600.0, 0.00058)), new(0.00528d, new GammaParticle(2162600.0, 0.00057)), new(0.00231d, new GammaParticle(2219000.0, 0.00056)), new(0.0033d, new GammaParticle(2279500.0, 0.00054)), new(0.00363d, new GammaParticle(2387600.0, 0.00052)), new(0.013859999999999999d, new GammaParticle(2448000.0, 0.00051)), new(0.0033d, new GammaParticle(2469300.0, 0.0005)), new(0.00198d, new GammaParticle(2703500.0, 0.00046)), new(0.0033d, new GammaParticle(2717200.0, 0.00046)), new(0.0049499999999999995d, new GammaParticle(2968500.0, 0.00042)), new(0.00231d, new GammaParticle(3085900.0, 0.0004)), new(0.00297d, new GammaParticle(3280000.0, 0.00038)), new(1.9736000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.0012792343085046359d, new GammaParticle(1127.0, 1.10013)), new(0.011097344315948665d, new GammaParticle(9225.0, 0.1344)), new(0.02156499089768493d, new GammaParticle(9252.0, 0.13401)), new(0.0047305191258711875d, new GammaParticle(10306.0, 0.1203)), new(0.004758902240626414d, new GammaParticle(10313.0, 0.12022)), new(2.8383114755227123e-05d, new GammaParticle(10365.0, 0.11962)) } },
            { 0.00010999999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc64()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    