using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese53 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese53";
        public override double halfLife { get; } = 116760626105990.4d;
        public override double atomicWeight { get; } = 52.94129d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chromium53()), new(0.0064605491999999995d, new GammaParticle(597.0, 2.07679)), new(0.07645109885275231d, new GammaParticle(5406.0, 0.22935)), new(0.15016911972648264d, new GammaParticle(5415.0, 0.22896)), new(0.030503081420765032d, new GammaParticle(5966.0, 0.20782)), new(0.030503081420765032d, new GammaParticle(5966.0, 0.20782)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    