using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Californium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium251";
        public override double halfLife { get; } = 28338119525.18362d;
        public override double atomicWeight { get; } = 251.07959d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Curium247()), new(1.0d, new AlphaParticle(7199002.09)), new(0.00037999999999999997d, new GammaParticle(38480.0, 0.03222)), new(0.00048d, new GammaParticle(52450.0, 0.02364)), new(0.00024d, new GammaParticle(58030.0, 0.02137)), new(0.0001d, new GammaParticle(60500.0, 0.02049)), new(0.004d, new GammaParticle(61670.0, 0.0201)), new(0.0004d, new GammaParticle(73000.0, 0.01698)), new(0.0004d, new GammaParticle(84350.0, 0.0147)), new(0.00024d, new GammaParticle(113700.0, 0.0109)), new(0.00014000000000000001d, new GammaParticle(134650.0, 0.00921)), new(0.0002d, new GammaParticle(157350.0, 0.00788)), new(0.0012d, new GammaParticle(165700.0, 0.00748)), new(0.17300000000000001d, new GammaParticle(177520.0, 0.00698)), new(0.068d, new GammaParticle(227380.0, 0.00545)), new(0.0013d, new GammaParticle(256650.0, 0.00483)), new(0.0043d, new GammaParticle(265860.0, 0.00466)), new(0.0012d, new GammaParticle(284200.0, 0.00436)), new(0.0113d, new GammaParticle(285410.0, 0.00434)), new(0.0007000000000000001d, new GammaParticle(289300.0, 0.00429)), new(0.003d, new GammaParticle(291200.0, 0.00426)), new(0.00024d, new GammaParticle(315800.0, 0.00393)), new(0.0005d, new GammaParticle(318300.0, 0.0039)), new(0.00043d, new GammaParticle(345900.0, 0.00358)), new(0.00013d, new GammaParticle(354300.0, 0.0035)), new(0.53287317995398d, new GammaParticle(18579.0, 0.06673)), new(0.1274238366190506d, new GammaParticle(104606.0, 0.01185)), new(0.19950498922663315d, new GammaParticle(109286.0, 0.01134)), new(0.0747196798715357d, new GammaParticle(123280.0, 0.01006)), new(0.10102100718631628d, new GammaParticle(124855.0, 0.00993)), new(0.026301327314780566d, new GammaParticle(126917.0, 0.00977)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    