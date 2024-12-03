using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium43m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium43m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 42.96153d;

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
    