using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium196m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium196m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 195.96862d;

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
    