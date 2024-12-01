using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Calcium44i : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium44i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 43.9682d;

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
    