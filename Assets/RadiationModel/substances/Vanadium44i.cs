using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Vanadium44i : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium44i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 43.97733d;

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
    