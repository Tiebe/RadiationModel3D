using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold196m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold196m";
        public override double halfLife { get; } = 8.1d;
        public override double atomicWeight { get; } = 195.96666d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold196()), new(0.0030499999999999998d, new GammaParticle(84660.0, 0.01464)), new(0.2502765572776d, new GammaParticle(11419.0, 0.10858)), new(0.0002457802905890165d, new GammaParticle(66991.0, 0.01851)), new(0.00041842065132621125d, new GammaParticle(68806.0, 0.01802)), new(0.00014118778749788393d, new GammaParticle(78048.0, 0.01589)), new(0.0001819910580847724d, new GammaParticle(78983.0, 0.0157)), new(4.080327058688846e-05d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    