using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin128m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin128m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 127.91275d;

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
    