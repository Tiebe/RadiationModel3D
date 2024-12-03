using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium242m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242m";
        public override double halfLife { get; } = 4449526562.41747d;
        public override double atomicWeight { get; } = 242.0596d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9954999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium242()), new(1.4200000000000002e-06d, new GammaParticle(48630.0, 0.0255)), new(0.249561895d, new GammaParticle(18078.0, 0.06858)) } },
            { 0.0045000000000000005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium238()), new(1.0d, new AlphaParticle(6659002.09)), new(6.2e-05d, new GammaParticle(26320.0, 0.04711)), new(0.00134d, new GammaParticle(49350.0, 0.02512)), new(2.1e-05d, new GammaParticle(53690.0, 0.02309)), new(9.6e-06d, new GammaParticle(57540.0, 0.02155)), new(5.4999999999999995e-05d, new GammaParticle(60130.0, 0.02062)), new(0.000149d, new GammaParticle(66890.0, 0.01854)), new(4e-05d, new GammaParticle(67930.0, 0.01825)), new(7.8e-05d, new GammaParticle(73660.0, 0.01683)), new(1e-05d, new GammaParticle(84900.0, 0.0146)), new(0.000228d, new GammaParticle(86650.0, 0.01431)), new(1.3e-05d, new GammaParticle(89600.0, 0.01384)), new(2.8e-05d, new GammaParticle(92520.0, 0.0134)), new(3.6e-05d, new GammaParticle(93820.0, 0.01322)), new(0.000197d, new GammaParticle(109590.0, 0.01131)), new(0.000197d, new GammaParticle(109590.0, 0.01131)), new(2.5e-05d, new GammaParticle(111160.0, 0.01115)), new(1.2999999999999998e-06d, new GammaParticle(126830.0, 0.00978)), new(2.7e-06d, new GammaParticle(131490.0, 0.00943)), new(6.7e-05d, new GammaParticle(135190.0, 0.00917)), new(9.400000000000001e-05d, new GammaParticle(136030.0, 0.00911)), new(1.4200000000000002e-06d, new GammaParticle(139050.0, 0.00892)), new(1.4200000000000002e-06d, new GammaParticle(139050.0, 0.00892)), new(8.3e-07d, new GammaParticle(151070.0, 0.00821)), new(7.249999999999999e-06d, new GammaParticle(152690.0, 0.00812)), new(7.249999999999999e-06d, new GammaParticle(152690.0, 0.00812)), new(3.31e-05d, new GammaParticle(153850.0, 0.00806)), new(2.7e-06d, new GammaParticle(156460.0, 0.00792)), new(4.1e-06d, new GammaParticle(160610.0, 0.00772)), new(1.5100000000000001e-05d, new GammaParticle(163250.0, 0.00759)), new(0.000153d, new GammaParticle(163250.0, 0.00759)), new(4.6e-07d, new GammaParticle(165970.0, 0.00747)), new(6.2e-06d, new GammaParticle(170500.0, 0.00727)), new(1.7e-06d, new GammaParticle(174760.0, 0.00709)), new(2.8e-07d, new GammaParticle(176680.0, 0.00702)), new(9.1e-06d, new GammaParticle(182860.0, 0.00678)), new(2.7e-06d, new GammaParticle(189010.0, 0.00656)), new(1.06e-06d, new GammaParticle(190880.0, 0.0065)), new(1.41e-05d, new GammaParticle(194610.0, 0.00637)), new(1e-06d, new GammaParticle(196460.0, 0.00631)), new(1.56e-05d, new GammaParticle(206370.0, 0.00601)), new(5.5e-07d, new GammaParticle(213200.0, 0.00582)), new(5.9e-06d, new GammaParticle(215520.0, 0.00575)), new(5.6e-06d, new GammaParticle(232400.0, 0.00533)), new(1.2999999999999998e-06d, new GammaParticle(233690.0, 0.00531)), new(4.6e-07d, new GammaParticle(237020.0, 0.00523)), new(1.6e-07d, new GammaParticle(238530.0, 0.0052)), new(5e-06d, new GammaParticle(250330.0, 0.00495)), new(1.1e-06d, new GammaParticle(250330.0, 0.00495)), new(2.9e-07d, new GammaParticle(270550.0, 0.00458)), new(3.7e-07d, new GammaParticle(272750.0, 0.00455)), new(6e-07d, new GammaParticle(280040.0, 0.00443)), new(2.8e-07d, new GammaParticle(299200.0, 0.00414)), new(0.0020499999999999997d, new GammaParticle(17136.0, 0.07235)), new(5.767794943421768e-06d, new GammaParticle(97078.0, 0.01277)), new(9.181462819837263e-06d, new GammaParticle(101068.0, 0.01227)), new(3.3480108532298875e-06d, new GammaParticle(114160.0, 0.01086)), new(4.499726586740969e-06d, new GammaParticle(115608.0, 0.01072)), new(1.1517157335110814e-06d, new GammaParticle(117470.0, 0.01055)) } },
            { 4.7e-11d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    