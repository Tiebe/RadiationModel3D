using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium255p : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium255p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 255.09109d;

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
    