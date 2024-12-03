using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium128m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium128m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 127.92062d;

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
    