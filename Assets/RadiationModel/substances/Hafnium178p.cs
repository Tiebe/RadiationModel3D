using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium178p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium178p";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 177.94647d;

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
    