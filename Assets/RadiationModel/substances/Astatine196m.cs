using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine196m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 195.99576d;

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
    