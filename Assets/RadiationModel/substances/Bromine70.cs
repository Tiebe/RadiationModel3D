using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine70 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine70";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 69.94479d;

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
    