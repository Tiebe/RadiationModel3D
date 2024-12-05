using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 170.94052d;

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
    