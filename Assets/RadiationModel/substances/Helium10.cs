using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Helium10 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium10";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 10.05282d;

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
    