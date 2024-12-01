using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium8i : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium8i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.0341d;

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
    