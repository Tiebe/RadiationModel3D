using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lead196n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead196n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 195.97472d;

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
    