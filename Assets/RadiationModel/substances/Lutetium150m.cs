using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium150m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 149.97343d;

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
    