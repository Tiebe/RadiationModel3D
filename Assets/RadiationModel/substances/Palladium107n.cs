using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium107n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium107n";
        public override double halfLife { get; } = 21.3d;
        public override double atomicWeight { get; } = 106.90536d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium107()), new(0.687d, new GammaParticle(214900.0, 0.00577)), new(0.01568023914d, new GammaParticle(3053.0, 0.40611)), new(0.05527445106025424d, new GammaParticle(21020.0, 0.05898)), new(0.10442934264170461d, new GammaParticle(21177.0, 0.05855)), new(0.02865113358806937d, new GammaParticle(23904.0, 0.05187)), new(0.033521826298041166d, new GammaParticle(24070.0, 0.05151)), new(0.0048706927099717925d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    