using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium219";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 219.01008d;

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
    