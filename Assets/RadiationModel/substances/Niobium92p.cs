using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium92p : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 91.90955d;

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
    