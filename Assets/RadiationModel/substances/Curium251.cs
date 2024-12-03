using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium251";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 251.08229d;

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
    