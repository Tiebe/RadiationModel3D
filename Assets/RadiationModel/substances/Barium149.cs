using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium149";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 148.94328d;

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
    