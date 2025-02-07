using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium93m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 92.92679d;

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
    