using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Astatine207m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine207m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 206.98807d;

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
    