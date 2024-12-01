using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum188 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum188";
        public override double halfLife { get; } = 877824.0d;
        public override double atomicWeight { get; } = 187.9594d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999997399999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium188()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0052d, new GammaParticle(41980.0, 0.02953)), new(0.0075d, new GammaParticle(54850.0, 0.0226)), new(0.00023d, new GammaParticle(92900.0, 0.01335)), new(0.0017000000000000001d, new GammaParticle(96700.0, 0.01282)), new(0.0034000000000000002d, new GammaParticle(98370.0, 0.0126)), new(0.0025d, new GammaParticle(132860.0, 0.00933)), new(0.023d, new GammaParticle(140350.0, 0.00883)), new(0.191d, new GammaParticle(187590.0, 0.00661)), new(0.184d, new GammaParticle(195050.0, 0.00636)), new(0.0003d, new GammaParticle(197800.0, 0.00627)), new(0.0031d, new GammaParticle(280300.0, 0.00442)), new(0.001d, new GammaParticle(283150.0, 0.00438)), new(0.0011d, new GammaParticle(290640.0, 0.00427)), new(0.07400000000000001d, new GammaParticle(381430.0, 0.00325)), new(0.043d, new GammaParticle(423340.0, 0.00293)), new(0.018000000000000002d, new GammaParticle(478300.0, 0.00259)), new(0.38d, new GammaParticle(10728.0, 0.11557)), new(0.23399999999999999d, new GammaParticle(63287.0, 0.01959)), new(0.4d, new GammaParticle(64896.0, 0.01911)), new(0.135d, new GammaParticle(73637.0, 0.01684)), new(0.17300000000000001d, new GammaParticle(74510.0, 0.01664)), new(0.038d, new GammaParticle(75576.0, 0.01641)) } },
            { 2.6e-07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium184()), new(1.0d, new AlphaParticle(5028602.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    