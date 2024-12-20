using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium203m";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 202.98211d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium203()), new(9e-13d, new GammaParticle(2300.0, 0.53906)), new(0.0017399999999999998d, new GammaParticle(62600.0, 0.01981)), new(0.035699999999999996d, new GammaParticle(577000.0, 0.00215)), new(0.30329999999999996d, new GammaParticle(639400.0, 0.00194)), new(0.3446d, new GammaParticle(641500.0, 0.00193)), new(0.110803700758049d, new GammaParticle(13292.0, 0.09328)), new(0.060592490361237775d, new GammaParticle(76862.0, 0.01613)), new(0.10090339777058746d, new GammaParticle(79290.0, 0.01564)), new(0.034738245959706114d, new GammaParticle(89837.0, 0.0138)), new(0.04554184045317472d, new GammaParticle(90941.0, 0.01363)), new(0.010803594493468602d, new GammaParticle(92315.0, 0.01343)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    