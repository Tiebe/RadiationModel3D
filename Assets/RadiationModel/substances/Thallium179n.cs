using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium179n : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium179n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 178.99209d;

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
    