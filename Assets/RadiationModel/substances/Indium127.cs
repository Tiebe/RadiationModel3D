using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 126.91747d;

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
    