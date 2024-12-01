using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten179p : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten179p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 178.95067d;

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
    