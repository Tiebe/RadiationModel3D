using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium229 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium229";
        public override double halfLife { get; } = 129600.0d;
        public override double atomicWeight { get; } = 229.0321d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9952d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium229()), new(1.5e-05d, new GammaParticle(13244.0, 0.09362)), new(6e-05d, new GammaParticle(29185.1, 0.04248)), new(2e-05d, new GammaParticle(29190.0, 0.04247)), new(0.00043999999999999996d, new GammaParticle(42440.0, 0.02921)), new(1.2e-06d, new GammaParticle(42442.5, 0.02921)), new(0.000143d, new GammaParticle(74542.0, 0.01663)), new(0.000105d, new GammaParticle(76350.0, 0.01624)), new(0.00047d, new GammaParticle(117200.0, 0.01058)), new(0.0012900000000000001d, new GammaParticle(119000.0, 0.01042)), new(0.00097d, new GammaParticle(146400.0, 0.00847)), new(0.000181d, new GammaParticle(148200.0, 0.00837)), new(0.3972222696472408d, new GammaParticle(15784.0, 0.07855)), new(0.18491459855308354d, new GammaParticle(89954.0, 0.01378)), new(0.29911775890178505d, new GammaParticle(93347.0, 0.01328)), new(0.10643643462358368d, new GammaParticle(105566.0, 0.01174)), new(0.14230551309173137d, new GammaParticle(106894.0, 0.0116)), new(0.0358690784681477d, new GammaParticle(108580.0, 0.01142)) } },
            { 0.0048d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium225()), new(1.0d, new AlphaParticle(6857002.09)), new(2.6e-05d, new GammaParticle(34800.0, 0.03563)), new(2.3999999999999997e-05d, new GammaParticle(34800.0, 0.03563)), new(0.00104d, new GammaParticle(40090.0, 0.03093)), new(0.00045d, new GammaParticle(64700.0, 0.01916)), new(6.5e-05d, new GammaParticle(67800.0, 0.01829)), new(0.00035000000000000005d, new GammaParticle(75120.0, 0.0165)), new(1.73e-05d, new GammaParticle(79000.0, 0.01569)), new(5.8e-06d, new GammaParticle(80600.0, 0.01538)), new(1.01e-05d, new GammaParticle(93600.0, 0.01325)), new(2.2000000000000003e-05d, new GammaParticle(94860.0, 0.01307)), new(5.8e-06d, new GammaParticle(111900.0, 0.01108)), new(0.000182d, new GammaParticle(115550.0, 0.01073)), new(0.000115d, new GammaParticle(120800.0, 0.01026)), new(8.2e-06d, new GammaParticle(122800.0, 0.0101)), new(3.6e-05d, new GammaParticle(125710.0, 0.00986)), new(3.5000000000000004e-05d, new GammaParticle(135200.0, 0.00917)), new(2.2000000000000003e-05d, new GammaParticle(140850.0, 0.0088)), new(5.3e-06d, new GammaParticle(152000.0, 0.00816)), new(9.6e-06d, new GammaParticle(155650.0, 0.00797)), new(2.4e-06d, new GammaParticle(158400.0, 0.00783)), new(1.9e-05d, new GammaParticle(169900.0, 0.0073)), new(3.8e-06d, new GammaParticle(179900.0, 0.00689)), new(3.5776337386898385e-05d, new GammaParticle(10869.0, 0.11407)), new(6.196397173541634e-05d, new GammaParticle(12500.0, 0.09919)), new(6.196397173541634e-05d, new GammaParticle(12651.0, 0.098)), new(0.0008057733645697833d, new GammaParticle(13368.0, 0.09275)), new(1.4390113354071417e-05d, new GammaParticle(14081.0, 0.08805)), new(0.000543252402392948d, new GammaParticle(14600.0, 0.08492)), new(4.222762278127165e-05d, new GammaParticle(15189.0, 0.08163)), new(9.18581635609553e-06d, new GammaParticle(15212.0, 0.0815)), new(0.00199265547658048d, new GammaParticle(15349.0, 0.08078)), new(0.00012932662501345023d, new GammaParticle(15600.0, 0.07948)), new(0.0005076512211019639d, new GammaParticle(15712.0, 0.07891)), new(2.2561654207953936e-06d, new GammaParticle(15789.0, 0.07853)), new(2.3689736918351634e-05d, new GammaParticle(15829.0, 0.07833)), new(3.9819117643960314e-05d, new GammaParticle(15929.0, 0.07784)), new(0.0006662089515773804d, new GammaParticle(16580.0, 0.07478)), new(0.00011254696903324d, new GammaParticle(17508.0, 0.07082)), new(3.9306328143065445e-06d, new GammaParticle(17812.0, 0.06961)), new(0.00011691967100183027d, new GammaParticle(18406.0, 0.06736)), new(1.1502300235197128e-05d, new GammaParticle(18734.0, 0.06618)), new(0.00011691967100183027d, new GammaParticle(18812.0, 0.06591)), new(1.23801665936564e-05d, new GammaParticle(18922.0, 0.06552)), new(2.1984895402053553e-05d, new GammaParticle(18998.0, 0.06526)), new(1.9986268547321414e-07d, new GammaParticle(19041.0, 0.06511)), new(5.5373108764354075e-06d, new GammaParticle(19654.0, 0.06308)), new(1.057941508912456e-06d, new GammaParticle(19825.0, 0.06254)), new(0.0008179357268610786d, new GammaParticle(87674.0, 0.01414)), new(0.0013295444194750953d, new GammaParticle(90886.0, 0.01364)), new(0.00046880474312365085d, new GammaParticle(102818.0, 0.01206)), new(0.0006249167225838265d, new GammaParticle(104107.0, 0.01191)), new(0.00015611197946017574d, new GammaParticle(105738.0, 0.01173)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    