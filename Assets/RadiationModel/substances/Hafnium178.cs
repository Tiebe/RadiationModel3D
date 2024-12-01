using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 177.94371d;

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
    