using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium90p : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium90p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 89.91144d;

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
    