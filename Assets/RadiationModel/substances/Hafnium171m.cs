using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171m";
        public override double halfLife { get; } = 29.5d;
        public override double atomicWeight { get; } = 170.94052d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium171()), new(1.84e-06d, new GammaParticle(21930.0, 0.05654)), new(0.18303999999999998d, new GammaParticle(9114.0, 0.13604)) } },
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
    