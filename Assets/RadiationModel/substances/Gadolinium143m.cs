using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium143m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 142.92691d;

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
    