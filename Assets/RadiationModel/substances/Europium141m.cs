using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium141m";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 140.92503d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.87d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium141()), new(0.0184d, new GammaParticle(96400.0, 0.01286)), new(0.110741617224d, new GammaParticle(6603.0, 0.18777)), new(0.024410918578061963d, new GammaParticle(40901.0, 0.03031)), new(0.04404712843389023d, new GammaParticle(41541.0, 0.02985)), new(0.013876631151071388d, new GammaParticle(47146.0, 0.0263)), new(0.017456801988047808d, new GammaParticle(47645.0, 0.02602)), new(0.003580170836976418d, new GammaParticle(48248.0, 0.0257)) } },
            { 0.13d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Promethium141()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0007599999999999999d, new GammaParticle(116000.0, 0.01069)), new(0.0054d, new GammaParticle(174200.0, 0.00712)), new(0.003d, new GammaParticle(369500.0, 0.00336)), new(0.006d, new GammaParticle(394000.0, 0.00315)), new(0.0011d, new GammaParticle(395600.0, 0.00313)), new(0.0043d, new GammaParticle(433900.0, 0.00286)), new(0.0045000000000000005d, new GammaParticle(518800.0, 0.00239)), new(0.0014000000000000002d, new GammaParticle(605900.0, 0.00205)), new(0.00045d, new GammaParticle(635600.0, 0.00195)), new(0.0044d, new GammaParticle(804400.0, 0.00154)), new(0.0054d, new GammaParticle(882900.0, 0.0014)), new(0.0029d, new GammaParticle(887300.0, 0.0014)), new(0.00015d, new GammaParticle(1225700.0, 0.00101)), new(0.004d, new GammaParticle(1595300.0, 0.00078)), new(0.2278d, new GammaParticle(511000.0, 0.00243)), new(0.00257237135488d, new GammaParticle(6354.0, 0.19513)), new(0.004281840795796681d, new GammaParticle(39522.0, 0.03137)), new(0.007749938091939694d, new GammaParticle(40117.0, 0.03091)), new(0.0024226149382063785d, new GammaParticle(45523.0, 0.02724)), new(0.003047649592263624d, new GammaParticle(45998.0, 0.02695)), new(0.0006250346540572455d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    