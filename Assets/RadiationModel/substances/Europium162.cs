using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium162";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 161.93696d;

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
    