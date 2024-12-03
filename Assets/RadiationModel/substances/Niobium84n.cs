using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium84n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium84n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 83.93467d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium84()), new(10.4d, new GammaParticle(47400.0, 0.02616)), new(0.78d, new GammaParticle(65000.0, 0.01907)), new(0.65d, new GammaParticle(114700.0, 0.01081)), new(0.494d, new GammaParticle(133300.0, 0.0093)), new(0.3705d, new GammaParticle(141400.0, 0.00877)), new(0.078d, new GammaParticle(163000.0, 0.00761)), new(0.299d, new GammaParticle(175400.0, 0.00707)), new(0.3185d, new GammaParticle(205900.0, 0.00602)), new(0.4098930305050425d, new GammaParticle(2299.0, 0.5393)), new(2.18737578215812d, new GammaParticle(16521.0, 0.07505)), new(4.177570248583117d, new GammaParticle(16615.0, 0.07462)), new(1.0809338780902293d, new GammaParticle(18694.0, 0.06632)), new(1.2430739598037635d, new GammaParticle(18795.0, 0.06597)), new(0.1621400817135344d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    