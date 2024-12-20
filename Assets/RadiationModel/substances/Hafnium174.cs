using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium174";
        public override double halfLife { get; } = 6.3113851949184e+22d;
        public override double atomicWeight { get; } = 173.94005d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium170()), new(1.0d, new AlphaParticle(3516331.0900000003)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    