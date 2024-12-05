using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium6i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium6i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.01895d;

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
    