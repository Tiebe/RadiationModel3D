using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium235";
        public override double halfLife { get; } = 2.221607588611277e+16d;
        public override double atomicWeight { get; } = 235.04393d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium231()), new(1.0d, new AlphaParticle(5700002.09)), new(0.005829999999999999d, new GammaParticle(19550.0, 0.06342)), new(0.00046d, new GammaParticle(31600.0, 0.03924)), new(0.00037d, new GammaParticle(34700.0, 0.03573)), new(0.0006900000000000001d, new GammaParticle(42020.0, 0.02951)), new(0.00034d, new GammaParticle(51210.0, 0.02421)), new(1.1000000000000001e-05d, new GammaParticle(54100.0, 0.02292)), new(0.00016d, new GammaParticle(54250.0, 0.02285)), new(1.7e-05d, new GammaParticle(64450.0, 0.01924)), new(0.00309d, new GammaParticle(72700.0, 0.01705)), new(0.000103d, new GammaParticle(73720.0, 0.01682)), new(0.00073d, new GammaParticle(74940.0, 0.01654)), new(4.6e-05d, new GammaParticle(76198.0, 0.01627)), new(0.00127d, new GammaParticle(96090.0, 0.0129)), new(0.016399999999999998d, new GammaParticle(109176.0, 0.01136)), new(0.00025299999999999997d, new GammaParticle(115450.0, 0.01074)), new(0.00021999999999999998d, new GammaParticle(120350.0, 0.0103)), new(0.000256d, new GammaParticle(136550.0, 0.00908)), new(0.00211d, new GammaParticle(140759.0, 0.00881)), new(5e-05d, new GammaParticle(142400.0, 0.00871)), new(0.1093d, new GammaParticle(143765.0, 0.00862)), new(0.00073d, new GammaParticle(150937.0, 0.00821)), new(0.0507d, new GammaParticle(163357.0, 0.00759)), new(0.00010999999999999999d, new GammaParticle(173000.0, 0.00717)), new(0.0007599999999999999d, new GammaParticle(175700.0, 0.00706)), new(0.000126d, new GammaParticle(179297.0, 0.00692)), new(0.00411d, new GammaParticle(182504.0, 0.00679)), new(0.5720000000000001d, new GammaParticle(185713.0, 0.00668)), new(0.00637d, new GammaParticle(194942.0, 0.00636)), new(0.00042d, new GammaParticle(198927.0, 0.00623)), new(0.001d, new GammaParticle(199600.0, 0.00621)), new(0.010700000000000001d, new GammaParticle(202110.0, 0.00613)), new(0.050300000000000004d, new GammaParticle(205311.0, 0.00604)), new(0.00029499999999999996d, new GammaParticle(215300.0, 0.00576)), new(0.00115d, new GammaParticle(221392.0, 0.0056)), new(1.8e-05d, new GammaParticle(225700.0, 0.00549)), new(6.9e-05d, new GammaParticle(228785.0, 0.00542)), new(0.000332d, new GammaParticle(233470.0, 0.00531)), new(0.00068d, new GammaParticle(240876.0, 0.00515)), new(0.000509d, new GammaParticle(246830.0, 0.00502)), new(0.00067d, new GammaParticle(251500.0, 0.00493)), new(6.6e-05d, new GammaParticle(266470.0, 0.00465)), new(0.00023d, new GammaParticle(275129.0, 0.00451)), new(8.6e-05d, new GammaParticle(275428.0, 0.0045)), new(0.0026d, new GammaParticle(279500.0, 0.00444)), new(6.3e-05d, new GammaParticle(281440.0, 0.00441)), new(4.4999999999999996e-05d, new GammaParticle(282920.0, 0.00438)), new(5.3e-05d, new GammaParticle(289560.0, 0.00428)), new(0.00037d, new GammaParticle(291650.0, 0.00425)), new(0.00033d, new GammaParticle(294300.0, 0.00421)), new(5.3e-05d, new GammaParticle(301700.0, 0.00411)), new(5.3e-05d, new GammaParticle(310690.0, 0.00399)), new(1.1000000000000001e-05d, new GammaParticle(317063.0, 0.00391)), new(4e-05d, new GammaParticle(325800.0, 0.00381)), new(7.2e-05d, new GammaParticle(343500.0, 0.00361)), new(0.0007199999999999999d, new GammaParticle(345400.0, 0.00359)), new(0.00034d, new GammaParticle(345920.0, 0.00358)), new(2.3999999999999997e-05d, new GammaParticle(356030.0, 0.00348)), new(0.0006900000000000001d, new GammaParticle(368500.0, 0.00336)), new(0.0006900000000000001d, new GammaParticle(371800.0, 0.00333)), new(0.000277d, new GammaParticle(387840.0, 0.0032)), new(0.0004d, new GammaParticle(390270.0, 0.00318)), new(2.3e-05d, new GammaParticle(410290.0, 0.00302)), new(1.4e-05d, new GammaParticle(428710.0, 0.00289)), new(4e-05d, new GammaParticle(433000.0, 0.00286)), new(1.1000000000000001e-05d, new GammaParticle(448400.0, 0.00277)), new(8.999999999999999e-05d, new GammaParticle(455100.0, 0.00272)), new(4.2000000000000004e-06d, new GammaParticle(517900.0, 0.00239)), new(4.2000000000000004e-06d, new GammaParticle(742500.0, 0.00167)), new(5.999999999999999e-06d, new GammaParticle(794700.0, 0.00156)), new(0.27699999999999997d, new GammaParticle(15784.0, 0.07855)), new(0.029914423277067514d, new GammaParticle(89954.0, 0.01378)), new(0.048389555608326605d, new GammaParticle(93347.0, 0.01328)), new(0.017218675985269914d, new GammaParticle(105566.0, 0.01174)), new(0.023021369792305874d, new GammaParticle(106894.0, 0.0116)), new(0.00580269380703596d, new GammaParticle(108580.0, 0.01142)) } },
            { 7e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 8e-12d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    