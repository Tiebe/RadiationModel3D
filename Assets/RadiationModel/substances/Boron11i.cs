using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Boron11i : RadioactiveSubstance
    {
        public override string name { get; } = "Boron11i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 11.02279d;

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
    