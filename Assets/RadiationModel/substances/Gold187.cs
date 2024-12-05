using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold187 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold187";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 186.96454d;

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
    