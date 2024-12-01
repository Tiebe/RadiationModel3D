using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium146n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium146n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 145.92826d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    