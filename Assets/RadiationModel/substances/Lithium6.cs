using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium6 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium6";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.01512d;

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
    