using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium49 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium49";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 48.96821d;

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
    