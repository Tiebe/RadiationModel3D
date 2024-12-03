using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine84m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine84m";
        public override double halfLife { get; } = 360.0d;
        public override double atomicWeight { get; } = 83.91683d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton84()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new GammaParticle(424000.0, 0.00292)), new(0.03d, new GammaParticle(447000.0, 0.00277)), new(0.98d, new GammaParticle(881600.0, 0.00141)), new(0.01d, new GammaParticle(1016000.0, 0.00122)), new(0.97d, new GammaParticle(1462800.0, 0.00085)), new(0.02d, new GammaParticle(1897700.0, 0.00065)), new(4.0405373550000004e-05d, new GammaParticle(1648.0, 0.75233)), new(0.00028404583963151045d, new GammaParticle(12596.0, 0.09843)), new(0.0005477166209631901d, new GammaParticle(12649.0, 0.09802)), new(0.00013124740134929096d, new GammaParticle(14169.0, 0.0875)), new(0.00014447713940529948d, new GammaParticle(14209.0, 0.08726)), new(1.3229738056008528e-05d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    