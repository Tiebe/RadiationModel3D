using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Curium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium249m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 249.07601d;

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
    