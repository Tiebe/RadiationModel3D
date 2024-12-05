using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus30 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus30";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 29.97831d;

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
    