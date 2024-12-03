using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium155m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 154.92466d;

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
    