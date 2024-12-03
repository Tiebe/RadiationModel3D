using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium47m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium47m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 46.95323d;

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
    