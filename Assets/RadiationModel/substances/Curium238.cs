using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium238";
        public override double halfLife { get; } = 7920.0d;
        public override double atomicWeight { get; } = 238.05308d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9616d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium238()) } },
            { 0.0384d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Plutonium234()), new(1.0d, new AlphaParticle(7692002.09)) } },
            { 0.00048d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    