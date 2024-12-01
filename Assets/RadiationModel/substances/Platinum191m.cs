using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum191m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum191m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 190.96179d;

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
    