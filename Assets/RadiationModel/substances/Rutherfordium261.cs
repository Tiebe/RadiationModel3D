using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 261.10877d;

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
    