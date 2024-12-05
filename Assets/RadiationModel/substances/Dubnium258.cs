using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium258 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium258";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 258.10898d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium258()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    