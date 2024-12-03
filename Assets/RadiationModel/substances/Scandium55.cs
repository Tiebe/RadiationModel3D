using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium55";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 54.96689d;

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
    