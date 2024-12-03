using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony124p : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony124p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 123.90598d;

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
    