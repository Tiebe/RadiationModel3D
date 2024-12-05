using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tin132m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin132m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.92303d;

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
    