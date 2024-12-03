using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Argon45 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon45";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 44.96804d;

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
    