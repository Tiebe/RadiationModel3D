using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium259";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 259.10949d;

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
    